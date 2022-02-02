using VDS.RDF;

IGraph g = new Graph();
g.BaseUri = new Uri("http://example.org/");

var karl = g.CreateUriNode(new Uri("https://karlhammar.com/me"));
var name = g.CreateUriNode(new Uri("https://karlhammar.com/name"));
var karlsname = g.CreateLiteralNode("Karl Hammar");

g.Assert(new Triple(karl, name, karlsname));

foreach (Triple t in g.Triples)
{
    Console.WriteLine(t.ToString());
}