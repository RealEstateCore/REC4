using CommandLine;
using VDS.RDF;
using VDS.RDF.Parsing;

namespace OWL2DTDL
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
        }
    }
}

