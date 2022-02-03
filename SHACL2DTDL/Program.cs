using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Shacl;
using VDS.RDF.Shacl.Validation;

namespace OWL2DTDL
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2) {
                return;
            }
            TurtleParser ttlparser = new TurtleParser();

            IGraph modelgraph = new Graph();
            ttlparser.Load(modelgraph, args[0]);
            ShapesGraph sgraph = new ShapesGraph(modelgraph);

            IGraph datagraph = new Graph();
            ttlparser.Load(datagraph, args[1]);

            Report report = sgraph.Validate(datagraph);
            Console.WriteLine("Report:");
            foreach (Result result in report.Results) {
                Console.WriteLine($"{result.FocusNode} -- {result.ResultPath} -- {result.Message}");
            }
        }
    }
}

