using CommandLine;
using SHACL2DTDL.VocabularyHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.JsonLd;
using VDS.RDF.Shacl;
using VDS.RDF.Writing;

namespace SHACL2DTDL
{
    class Program
    {
        public class Options
        {
            [Option('n', "no-imports", Required = false, HelpText = "Sets program to not follow owl:Imports declarations.")]
            public bool NoImports { get; set; }
            [Option('f', "file-path", Required = true, HelpText = "The path to the on-disk root ontology file to translate.", SetName = "fileOntology")]
            public string? FilePath { get; set; }
            [Option('u', "uri-path", Required = true, HelpText = "The URI of the root ontology file to translate.", SetName = "uriOntology")]
            public string? UriPath { get; set; }
            [Option('o', "outputPath", Required = true, HelpText = "The directory in which to create DTDL models.")]
            public string? OutputPath { get; set; }
            [Option('m', "merged-output", Required = false, HelpText = "Sets program to output one merged JSON-LD file for batch import into ADT.")]
            public bool MergedOutput { get; set; }
            [Option('i', "ignorefile", Required = false, HelpText = "Path to a CSV file, the first column of which lists (whole or partial) IRI:s that should be ignored by this tool and not translated into DTDL output.")]
            public string? IgnoreFile { get; set; }
            [Option('s', "ontologySource", Required = false, HelpText = "An identifier for the ontology source; will be used to generate DTMI:s per the following design, where interfaceName is the local name of a translated OWL class, and ontologyName is the last segment of the translated class's namespace: <dtmi:digitaltwins:{ontologySource}:{ontologyName}:{interfaceName};1>.")]
            public string? OntologySource { get; set; }
        }

        // Configuration fields
        private static bool _noImports;
        private static bool _localOntology;
        private static string _ontologyPath = "";
        private static string? _outputPath;
        private static bool _mergedOutput;
        private static string? _ontologySource;

        /// <summary>
        /// The RDF graph holding the SHACL-formatted ontology upon which this tool subsequently operates.
        /// </summary>
        private static readonly IGraph _ontologyGraph = new Graph();
        private static readonly ShapesGraph _shapesGraph = new ShapesGraph(_ontologyGraph);

        /// <summary>
        /// URIs that will be ignored by this tool, parsed from CSV file using -i command line option
        /// </summary>
        private static readonly HashSet<string> ignoredUris = new HashSet<string>();

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed(o =>
                   {
                       _outputPath = o.OutputPath;
                       _noImports = o.NoImports;
                       _mergedOutput = o.MergedOutput;
                       if (o.FilePath != null)
                       {
                           _localOntology = true;
                           _ontologyPath = o.FilePath;
                       }
                       else if (o.UriPath != null)
                       {
                           _localOntology = false;
                           _ontologyPath = o.UriPath;
                       }

                       // Parse ignored namespaces from ignorefile
                       if (o.IgnoreFile != null)
                       {
                           using (var reader = new StreamReader(o.IgnoreFile))
                           {
                               string ignoredNamesCsv = reader.ReadToEnd();
                               string[] lines = ignoredNamesCsv.Split(Environment.NewLine);
                               IEnumerable<string> values = lines.Select(line => line.Split(';').First());
                               ignoredUris.UnionWith(values);
                           }
                       }

                       if (o.OntologySource != null)
                       {
                           _ontologySource = o.OntologySource;
                       }
                   })
                   .WithNotParsed((errs) =>
                   {
                       Environment.Exit(1);
                   });

            // Turn off caching
            UriLoader.CacheDuration = TimeSpan.MinValue;

            // Load ontology graph from local or remote path
            Console.WriteLine($"Loading {_ontologyPath}.");
            if (_localOntology)
            {
                FileLoader.Load(_ontologyGraph, _ontologyPath);
            }
            else
            {
                UriLoader.Load(_ontologyGraph, new Uri(_ontologyPath));
            }

            // TODO:Possibly implement (recursive) model loading over owl:imports statements

            // Execute the main logic that generates DTDL interfaces.
            GenerateInterfaces();
        }

        /// <summary>
        /// Method that traverses the sets of SHACL node shapes in the imported ontology graph and generates DTDL representations.
        /// </summary>
        private static void GenerateInterfaces()
        {
            // Working graph
            Graph dtdlModel = new Graph();

            // A whole bunch of language definitions.
            // TODO Extract all of these (often reused) node definitions into statics.

            // RDF/OWL specs
            IUriNode rdfType = dtdlModel.CreateUriNode(UriFactory.Create(RdfSpecsHelper.RdfType));

            // DTDL classes
            IUriNode dtdl_Interface = dtdlModel.CreateUriNode(DTDL.Interface);
            IUriNode dtdl_Property = dtdlModel.CreateUriNode(DTDL.Property);
            IUriNode dtdl_Relationship = dtdlModel.CreateUriNode(DTDL.Relationship);
            IUriNode dtdl_Telemetry = dtdlModel.CreateUriNode(DTDL.Telemetry);
            IUriNode dtdl_Component = dtdlModel.CreateUriNode(DTDL.Component);
            IUriNode dtdl_Enum = dtdlModel.CreateUriNode(DTDL.Enum);
            IUriNode dtdl_EnumValue = dtdlModel.CreateUriNode(DTDL.EnumValue);
            IUriNode dtdl_Map = dtdlModel.CreateUriNode(DTDL.Map);

            // DTDL properties
            IUriNode dtdl_contents = dtdlModel.CreateUriNode(DTDL.contents);
            IUriNode dtdl_name = dtdlModel.CreateUriNode(DTDL.name);
            IUriNode dtdl_displayName = dtdlModel.CreateUriNode(DTDL.displayName);
            IUriNode dtdl_description = dtdlModel.CreateUriNode(DTDL.description);
            IUriNode dtdl_properties = dtdlModel.CreateUriNode(DTDL.properties);
            IUriNode dtdl_mapKey = dtdlModel.CreateUriNode(DTDL.mapKey);
            IUriNode dtdl_mapValue = dtdlModel.CreateUriNode(DTDL.mapValue);

            IUriNode dtdl_extends = dtdlModel.CreateUriNode(DTDL.extends);
            IUriNode dtdl_maxMultiplicity = dtdlModel.CreateUriNode(DTDL.maxMultiplicity);
            IUriNode dtdl_minMultiplicity = dtdlModel.CreateUriNode(DTDL.minMultiplicity);
            IUriNode dtdl_target = dtdlModel.CreateUriNode(DTDL.target);
            IUriNode dtdl_schema = dtdlModel.CreateUriNode(DTDL.schema);
            IUriNode dtdl_valueSchema = dtdlModel.CreateUriNode(DTDL.valueSchema);
            IUriNode dtdl_writable = dtdlModel.CreateUriNode(DTDL.writable);

            IUriNode dtdl_enumValue = dtdlModel.CreateUriNode(DTDL.enumValue);
            IUriNode dtdl_enumValues = dtdlModel.CreateUriNode(DTDL.enumValues);

            Console.WriteLine();
            Console.WriteLine("Generating DTDL Interface declarations: ");

            // Get only explicit node shapes
            foreach(NodeShape shape in _shapesGraph.NodeShapes().Where(nodeShape => !IsIgnored(nodeShape) && !nodeShape.SuperClasses.Any(parent => IsIgnored(parent)))) {
                
                // Create Interface
                string interfaceDtmi = GetDTMI(shape.Node);
                Console.WriteLine($"\t* {interfaceDtmi}");
                IUriNode interfaceNode = dtdlModel.CreateUriNode(UriFactory.Create(interfaceDtmi));
                dtdlModel.Assert(new Triple(interfaceNode, rdfType, dtdl_Interface));

                // If there are rdfs:labels, use them for DTDL displayName
                Dictionary<string,string> displayNameMap = new();
                foreach (LiteralNode shapeLabel in shape.Node.RdfsLabels()) {
                    // Flatten possibly multiple occurences of labels with a given language tag, keep only one
                    displayNameMap[shapeLabel.Language] = shapeLabel.Value;
                }
                foreach (string shapeLabelLanguageTag in displayNameMap.Keys) {
                    // Create a displayName assertion for reach of the above labels
                    ILiteralNode dtdlDisplayNameLiteral;
                    if (shapeLabelLanguageTag == String.Empty) // Fall back to EN language if none is defined b/c DTDL validator cannot handle language @none
                        dtdlDisplayNameLiteral = dtdlModel.CreateLiteralNode(string.Concat(displayNameMap[shapeLabelLanguageTag].Take(64)),"en");
                    else
                        dtdlDisplayNameLiteral = dtdlModel.CreateLiteralNode(string.Concat(displayNameMap[shapeLabelLanguageTag].Take(64)), shapeLabelLanguageTag);
                    dtdlModel.Assert(new Triple(interfaceNode, dtdl_displayName, dtdlDisplayNameLiteral));
                }

                // If there are rdfs:comments, use them for DTDL description
                Dictionary<string,string> descriptionMap = new();
                foreach (LiteralNode shapeComment in shape.Node.RdfsComments()) {
                    // Flatten possibly multiple occurences of comments with a given language tag, keep only one
                    descriptionMap[shapeComment.Language] = shapeComment.Value;
                }
                foreach (string shapeCommentLanguageTag in descriptionMap.Keys) {
                    // Create a description assertion for reach of the above comments
                    ILiteralNode dtdlDescriptionLiteral;
                    if (shapeCommentLanguageTag == String.Empty) // Fall back to EN language if none is defined b/c DTDL validator cannot handle language @none
                        dtdlDescriptionLiteral = dtdlModel.CreateLiteralNode(string.Concat(descriptionMap[shapeCommentLanguageTag].Take(512)),"en");
                    else
                        dtdlDescriptionLiteral = dtdlModel.CreateLiteralNode(string.Concat(descriptionMap[shapeCommentLanguageTag].Take(512)), shapeCommentLanguageTag);
                    dtdlModel.Assert(new Triple(interfaceNode, dtdl_description, dtdlDescriptionLiteral));
                }

                // If the class has direct superclasses, implement DTDL extends (for at most two, see limitation in DTDL spec)
                IEnumerable<NodeShape> namedSuperClasses = shape.DirectSuperClasses.Where(superClass => !superClass.IsTopThing && !superClass.IsDeprecated);
                if (namedSuperClasses.Any())
                {
                    foreach (NodeShape superClass in namedSuperClasses.Take(2))
                    {
                        string superInterfaceDTMI = GetDTMI(superClass.Node);
                        IUriNode superInterfaceNode = dtdlModel.CreateUriNode(UriFactory.Create(superInterfaceDTMI));
                        dtdlModel.Assert(new Triple(interfaceNode, dtdl_extends, superInterfaceNode));
                    }
                }

                // TODO: Create reasonable top-level categories (not current Entity/Resource)

                // TODO: Implement cardinality of relationships and properties
                // TODO: Support different types of property paths, see https://www.w3.org/TR/shacl/#property-paths 
                // (currently we only support simple ) predicate paths, i.e., where ps.Path.NodeType = NodeType.Uri
                foreach (PropertyShape ps in shape.PropertyShapes.Where(ps => ps.Path.NodeType == NodeType.Uri)) {
                    // TODO: We also need to capture properties using rdfs:domain.
                    // TODO: We also need to avoid re-asserting on subclasses fields that are asserted on superclasses (disallowed in DTDL)
                    // TODO: We also need to filter out any deprecated shapes from source SHACL
                    string psPathLocalName = ((IUriNode)ps.Path).LocalName();

                    // We take different path here depending on whether it's a data field (DTDL Property) or a URI field (DTDL Relationship)
                    if (ps.Datatype is IUriNode datatype || (ps.NodeKind is IUriNode nodeKind1 && nodeKind1.LocalName() == "Literal")) {
                        // Target is an datatype, so this becomes a DTDL Property
                        IBlankNode propertyNode = dtdlModel.CreateBlankNode();
                        dtdlModel.Assert(new Triple(interfaceNode, dtdl_contents, propertyNode));

                        // Assert that this is indeed a Property
                        dtdlModel.Assert(new Triple(propertyNode, rdfType, dtdl_Property));

                        // Assert the property name
                        ILiteralNode propertyNameNode = dtdlModel.CreateLiteralNode(psPathLocalName);
                        dtdlModel.Assert(new Triple(propertyNode, dtdl_name, propertyNameNode));

                        // Assert the property schema (falling back to string if none is defined)
                        Uri propertySchema;
                        if (ps.Datatype != null && ps.Datatype is IUriNode) {
                            propertySchema = GetXsdAsDtdl((IUriNode)ps.Datatype);
                        }
                        else {
                            propertySchema = DTDL._string;
                        }
                        IUriNode schemaNode = dtdlModel.CreateUriNode(propertySchema);
                        dtdlModel.Assert(new Triple(propertyNode, dtdl_schema, schemaNode));

                    }
                    else if ((ps.Class.FirstOrDefault() is IUriNode cls || ps.NodeKind is IUriNode nodeKind2 && nodeKind2.LocalName() == "IRI")) { 
                        // Target is an RDFS class, so this becomes a DTDL Relationship
                        // DTDL supports only single targets, so we choose the first one if multiple exist (probably rare anyway)
                        
                        // Define a Relationship and its name
                        IBlankNode relationshipNode = dtdlModel.CreateBlankNode();
                        dtdlModel.Assert(new Triple(interfaceNode, dtdl_contents, relationshipNode));

                        // Assert that this is indeed a Relationship
                        dtdlModel.Assert(new Triple(relationshipNode, rdfType, dtdl_Relationship));

                        // Assert the relationship name
                        ILiteralNode relationshipNameNode = dtdlModel.CreateLiteralNode(psPathLocalName);
                        dtdlModel.Assert(new Triple(relationshipNode, dtdl_name, relationshipNameNode));

                        // Assert the relationship target (falling back to no target if class count <> 1)
                        if (ps.Class.Count() == 1 && ps.Class.First() is IUriNode) {
                            IUriNode shClassNode = (IUriNode)ps.Class.First();
                            string targetDtmi = GetDTMI(shClassNode);
                            IUriNode targetNode = dtdlModel.CreateUriNode(UriFactory.Create(targetDtmi));
                            dtdlModel.Assert(new Triple(relationshipNode, dtdl_target, targetNode));
                        }
                    }
                }
                

                 // Write JSON-LD to target file.
                JObject modelAsJsonLd = ToJsonLd(dtdlModel);

                List<IUriNode> parentDirectories = shape.LongestSuperClassesPath;
                string modelPath = string.Join("/", parentDirectories.Select(parent => parent.LocalName()));
                string modelOutputPath = $"{_outputPath}/{modelPath}/";
                // If the class has subclasses, place it with them
                if (shape.DirectSubClasses.Any()) { modelOutputPath += $"{shape.Node.LocalName()}/"; }
                Directory.CreateDirectory(modelOutputPath);
                string outputFileName = modelOutputPath + shape.Node.LocalName() + ".json";
                using (StreamWriter file = File.CreateText(outputFileName))
                using (JsonTextWriter writer = new JsonTextWriter(file) { Formatting = Formatting.Indented })
                {
                    modelAsJsonLd.WriteTo(writer);
                }

                // Clear the working graph for next iteration
                dtdlModel.Clear();
            }

        }

            // TODO: Implement this properly in adherence w/ https://github.com/Azure/digital-twin-model-identifier
        private static string GetDTMI(INode inputNode) {
            if (inputNode.NodeType == NodeType.Literal) {
                throw new ArgumentException("Attempting to generate DTMI from literal node.");
            }
            if (inputNode.NodeType == NodeType.Blank) {
                return $"dtmi:digitaltwins:{System.Guid.NewGuid().ToString()};1";
            }
            IUriNode node = (IUriNode)inputNode;
            string hostPortion = node.Uri.Host.Replace('.',':');
            string pathPortion = node.Uri.LocalPath.Trim('/').Replace('/',':');
            string fragmentPortion = node.Uri.Fragment.Trim('#');
            string dtmi = $"{hostPortion}:{pathPortion}:{fragmentPortion}";
            string cleanedDtmi = "";
            foreach (string segment in dtmi.Split(':')) {
                string cleanedSegment = Regex.Replace(segment, @"[^a-zA-Z0-9_]", "");
                cleanedSegment = cleanedSegment.TrimEnd('_');
                char[] digits = {'0','1','2','3','4','5','6','7','8','9'};
                cleanedSegment = cleanedSegment.TrimStart(digits);
                if (cleanedSegment.Length > 0) {
                    cleanedDtmi += $"{cleanedSegment}:";
                }
            }
            cleanedDtmi = cleanedDtmi.TrimEnd(':');
            string dtmiVersion = "1";
            return $"dtmi:digitaltwins:{cleanedDtmi};{dtmiVersion}";
        }

        /// <summary>
        /// Do JSON-LD framing and compacting of a model (i.e., a DTDL Interface) using the DTDL context file.
        /// </summary>
        /// <param name="dtdlModel">DTDL model to frame/compact, as DotNetRDF graph.</param>
        /// <returns>JSON-LD representation of input Interface</returns>
        private static JObject ToJsonLd(Graph dtdlModel)
        {
            JArray initialJsonLd;
            using (TripleStore entitiesStore = new TripleStore())
            {
                entitiesStore.Add(dtdlModel);
                JsonLdWriterOptions writerOptions = new JsonLdWriterOptions();
                writerOptions.UseNativeTypes = true;
                JsonLdWriter jsonLdWriter = new JsonLdWriter(writerOptions);
                initialJsonLd = jsonLdWriter.SerializeStore(entitiesStore);
            }

            // Configure and run JSON-LD framing and compacting
            JsonLdProcessorOptions options = new JsonLdProcessorOptions();
            options.UseNativeTypes = true;
            options.Base = new Uri("https://example.org"); // Throwaway base, not actually used

            JObject frame = new JObject(
                new JProperty("@type", DTDL.Interface.AbsoluteUri)
                );

            JObject context;
            using (StreamReader file = File.OpenText(@"DTDL.v2.context.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                context = (JObject)JToken.ReadFrom(reader);
            }

            JObject framedJson = JsonLdProcessor.Frame(initialJsonLd, frame, options);
            JObject compactedJson = JsonLdProcessor.Compact(framedJson, context, options);

            compactedJson["@context"] = new JValue(DTDL.dtdlContext);

            return compactedJson;
        }

        /// <summary>
        /// Checks if a given Shape should be ignored by tis tool.
        /// </summary>
        /// <param name="shape">SHACL shape to check</param>
        /// <returns>True iff the resource is ignored</returns>
        private static bool IsIgnored(Shape shape)
        {
            // If the shape is backed by a URI node, it is ignored IFF it is part of the ignoredUris set
            if (shape.Node.NodeType == NodeType.Uri) {
                string shapeUri = ((IUriNode)shape.Node).Uri.AbsoluteUri;
                return ignoredUris.Any(ignoredUri => shapeUri.Contains(ignoredUri));
            }
            // If the shape isn't backed by a single URI node (e.g., sequence paths, 
            // alternative paths, etc) then we ignore it (for now..)
            return true;
        }

        /// <summary>
        /// Translate an XSD datatype into a DTDL URI
        /// </summary>
        /// <param name="xsdDatatype">XSD datatype to translate</param>
        /// <returns>DTDL-equivalent URI</returns>
        private static Uri GetXsdAsDtdl(IUriNode xsdDatatype)
        {
            Dictionary<string, Uri> xsdDtdlPrimitiveTypesMappings = new Dictionary<string, Uri>
                {
                    {"boolean", DTDL._boolean },
                    {"byte", DTDL._integer },
                    {"date", DTDL._date },
                    {"dateTime", DTDL._dateTime },
                    {"duration", DTDL._duration },
                    {"dateTimeStamp", DTDL._dateTime },
                    {"double", DTDL._double },
                    {"float", DTDL._float },
                    {"int", DTDL._integer },
                    {"integer", DTDL._integer },
                    {"long", DTDL._long },
                    {"string",DTDL._string }
                };

            if (xsdDtdlPrimitiveTypesMappings.ContainsKey(xsdDatatype.LocalName()))
            {
                return xsdDtdlPrimitiveTypesMappings[xsdDatatype.LocalName()];
                
            }

            // Fall-back option
            return DTDL._string;
        }
    }
}

