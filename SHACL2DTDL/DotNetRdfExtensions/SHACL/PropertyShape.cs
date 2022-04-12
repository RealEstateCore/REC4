using VDS.RDF;
using VDS.RDF.Parsing;
using VDS.RDF.Shacl;

namespace DotNetRdfExtensions.SHACL
{
    public class PropertyShape: Shape {

        public PropertyShape(INode node, ShapesGraph graph): base(node, graph) {
        }

        public INode Path {
            get {
                IUriNode shPath = _graph.CreateUriNode(SH.path);
                return _graph.GetTriplesWithSubjectPredicate(_node, shPath).First().Object;
            }
        }

        public IUriNode? Datatype {
            get {
                IUriNode shDatatype = _graph.CreateUriNode(SH.datatype);
                return _graph.GetTriplesWithSubjectPredicate(_node, shDatatype).Select(trip => trip.Object).UriNodes().FirstOrDefault();
            }
        }

        public IEnumerable<IUriNode> Class {
            get {
                IUriNode shClass = _graph.CreateUriNode(SH.cls);
                return _graph.GetTriplesWithSubjectPredicate(_node, shClass).Select(trip => trip.Object).UriNodes();
            }
        }

        public int? MinCount {
            get {
                IUriNode shMinCount = _graph.CreateUriNode(SH.minCount);
                IEnumerable<int> minCounts = _graph.GetTriplesWithSubjectPredicate(_node, shMinCount)
                    .Select(triple => triple.Object)
                    .LiteralNodes()
                    .Where(node => node.DataType.AbsoluteUri == XmlSpecsHelper.XmlSchemaDataTypeInt)
                    .Select(node => int.Parse(node.Value));
                if (minCounts.Count() == 1) {
                    return minCounts.First();
                }
                else {
                    return null;
                }
            }
        }

        public int? MaxCount {
            get {
                IUriNode shMaxCount = _graph.CreateUriNode(SH.maxCount);
                IEnumerable<int> maxCounts = _graph.GetTriplesWithSubjectPredicate(_node, shMaxCount)
                    .Select(triple => triple.Object)
                    .LiteralNodes()
                    .Where(node => node.DataType.AbsoluteUri == XmlSpecsHelper.XmlSchemaDataTypeInt)
                    .Select(node => int.Parse(node.Value));
                if (maxCounts.Count() == 1) {
                    return maxCounts.First();
                }
                else {
                    return null;
                }
            }
        }
    }
}