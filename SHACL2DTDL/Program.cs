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
            foreach (Result res in report.Results) 
            {
                Console.WriteLine(res.Message);
                Console.WriteLine(res.ToString());
            }


            /*foreach (Triple t in sgraph.Triples)
            {
                Console.WriteLine(t.ToString());
            }*/

            /*IGraph g = new Graph();
            g.BaseUri = new Uri("http://example.org/");

            var karl = g.CreateUriNode(new Uri("https://karlhammar.com/me"));
            var name = g.CreateUriNode(new Uri("https://karlhammar.com/name"));
            var karlsname = g.CreateLiteralNode("Karl Hammar");

            g.Assert(new Triple(karl, name, karlsname));

            foreach (Triple t in g.Triples)
            {
                Console.WriteLine(t.ToString());
            }*/
        }
    }
}

