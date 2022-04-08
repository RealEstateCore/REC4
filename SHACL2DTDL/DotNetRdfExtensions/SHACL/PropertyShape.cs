using VDS.RDF;
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

        public INode? Datatype {
            get {
                IUriNode shDatatype = _graph.CreateUriNode(SH.datatype);
                return _graph.GetTriplesWithSubjectPredicate(_node, shDatatype).Select(trip => trip.Object).FirstOrDefault();
            }
        }

        public IEnumerable<INode> Class {
            get {
                IUriNode shClass = _graph.CreateUriNode(SH.cls);
                return _graph.GetTriplesWithSubjectPredicate(_node, shClass).Select(trip => trip.Object);
            }
        }

        
    }
}