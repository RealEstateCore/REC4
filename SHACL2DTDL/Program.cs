using CommandLine;
using SHACL2DTDL.VocabularyHelper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.JsonLd;
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
        private static string? _ontologyPath;
        private static string? _outputPath;
        private static bool _mergedOutput;
        private static string? _ontologySource;

        /// <summary>
        /// The RDF graph holding the SHACL-formatted ontology upon which this tool subsequently operates.
        /// </summary>
        private static readonly IGraph _ontologyGraph = new Graph();

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
                       else
                       {
                           _localOntology = false;
                           _ontologyPath = o.UriPath;
                       }

                       // Parse ignored namespaces from ignorefile
                       if (o.IgnoreFile != null)
                       {
                           using (var reader = new StreamReader(o.IgnoreFile))
                           {
                               while (!reader.EndOfStream)
                               {
                                   var line = reader.ReadLine();
                                   var values = line.Split(';');
                                   ignoredUris.Add(values[0]);
                               }
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
            foreach (Triple t in _ontologyGraph.Triples) {
                Console.WriteLine(t.ToString());
            }


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

            // TODO Get only explicit node shapes
            foreach(UriNode shapeNode in _ontologyGraph.Nodes.UriNodes()) {

                // Create Interface
                string interfaceDtmi = GetDTMI(shapeNode);
                Console.WriteLine($"\t* {interfaceDtmi}");
                IUriNode interfaceNode = dtdlModel.CreateUriNode(UriFactory.Create(interfaceDtmi));
                dtdlModel.Assert(new Triple(interfaceNode, rdfType, dtdl_Interface));

                // If there are rdfs:labels, use them for DTDL displayName
                /*if (shapeNode.Label.Any()) {
                    dtdlModel.Assert(GetDtdlDisplayNameTriples(oClass, interfaceNode));
                 }*/

                // TODO: All of the rest of the stuff

                 // Write JSON-LD to target file.
                JObject modelAsJsonLd = ToJsonLd(dtdlModel);

                Directory.CreateDirectory(_outputPath);
                string outputFileName = _outputPath + interfaceDtmi.Replace(':','.').Replace(';','.') + ".json";
                using (StreamWriter file = File.CreateText(outputFileName))
                using (JsonTextWriter writer = new JsonTextWriter(file) { Formatting = Formatting.Indented })
                {
                    modelAsJsonLd.WriteTo(writer);
                }

                // Clear the working graph for next iteration
                dtdlModel.Clear();
            }

        }

        private static string GetDTMI(IUriNode node) {
            // TODO: Implement me
            string hostPortion = node.Uri.Host.Replace('.',':');
            string pathPortion = node.Uri.LocalPath.Trim('/').Replace('/',':');
            string fragmentPortion = node.Uri.Fragment.Trim('#');
            string dtmi = $"{hostPortion}:{pathPortion}:{fragmentPortion}";
            string dtmiVersion = "1";
            return $"dtmi:digitaltwins:{dtmi};{dtmiVersion}";
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
    }
}

