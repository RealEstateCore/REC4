using VDS.RDF;
using VDS.RDF.Shacl;
using SHACL2DTDL.VocabularyHelper;

namespace SHACL2DTDL
{
    public static class DotNetRdfExtensions
    {
        public static IEnumerable<NodeShape> NodeShapes(this ShapesGraph graph) {
            IUriNode rdfType = graph.CreateUriNode(RDF.type);
            IUriNode shNodeShape = graph.CreateUriNode(SH.NodeShape);
            foreach (Triple t in graph.GetTriplesWithPredicateObject(rdfType, shNodeShape)) {
                yield return new NodeShape(t.Subject, graph);
            }
        }
    }

    public class Shape {
        /// <summary>
        /// The Node which this NodeShape is a wrapper around.
        /// </summary>
        protected INode _node;
        /// <summary>
        /// The Graph from which this Shape originates.
        /// </summary>
        protected ShapesGraph _graph;
        public IEnumerable<ILiteralNode> Label { 
            get {
                IUriNode rdfsLabel = _graph.CreateUriNode(RDFS.label);
                foreach (Triple t in _graph.GetTriplesWithSubjectPredicate(_node, rdfsLabel))
                {
                    if (t.Object.NodeType == NodeType.Literal) {
                        yield return (ILiteralNode)t.Object;
                    }
                }
            }
        }

        protected internal Shape(INode node, ShapesGraph graph) {
            _node = node;
            _graph = graph;
        }

        public INode Node
        {
            get
            {
                return _node;
            }
        }

        public ShapesGraph Graph
        {
            get
            {
                return _graph;
            }
        }
    }

    public class  NodeShape: Shape {
        public NodeShape(INode node, ShapesGraph graph): base(node, graph) {
        }
    }
}