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
                if (t.Subject.NodeType == NodeType.Uri) {
                    yield return new NodeShape((IUriNode)t.Subject, graph);
                }
            }
        }

        public static string LocalName(this IUriNode node)
        {
            if (node.Uri.Fragment.Length > 0)
            {
                return node.Uri.Fragment.Trim('#');
            }
            return System.IO.Path.GetFileName(node.Uri.AbsolutePath);
        }
    }

    public class Shape {
        /// <summary>
        /// The Node which this NodeShape is a wrapper around.
        /// </summary>
        protected IUriNode _node;
        /// <summary>
        /// The Graph from which this Shape originates.
        /// </summary>
        protected ShapesGraph _graph;
        public IEnumerable<ILiteralNode> Labels { 
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

        public IEnumerable<Shape> DirectSuperClasses {
            get {
                IUriNode rdfsSubClassOf = _graph.CreateUriNode(RDFS.subClassOf);
                foreach (Triple t in _graph.GetTriplesWithSubjectPredicate(_node, rdfsSubClassOf))
                {
                    if (t.Object.NodeType == NodeType.Uri) {
                        yield return new Shape((IUriNode)t.Object, _graph);
                    }
                }
            }
        }

        public IEnumerable<Shape> DirectSubClasses {
            get {
                IUriNode rdfsSubClassOf = _graph.CreateUriNode(RDFS.subClassOf);
                foreach (Triple t in _graph.GetTriplesWithPredicateObject(rdfsSubClassOf,_node))
                {
                    if (t.Subject.NodeType == NodeType.Uri) {
                        yield return new Shape((IUriNode)t.Subject, _graph);
                    }
                }
            }
        }

        public bool IsOwlThing
        {
            get {
                return _node.Uri.AbsoluteUri.Equals(OWL.Thing.AbsoluteUri);
            }            
        }

        public List<IUriNode> LongestSuperClassesPath {
            get {
                IEnumerable<Shape> directSuperClasses = this.DirectSuperClasses;
                if (directSuperClasses.Count() < 1 || directSuperClasses.Any(superClass => superClass.IsOwlThing)) {
                    return new List<IUriNode>();
                }
                else {
                    // Assume the first parent has the longest path; if not, it will be replaced in subsequent foreach
                    Shape longestParent = directSuperClasses.First();
                    List<IUriNode> longestParentPath = longestParent.LongestSuperClassesPath;
                     // Iterate through the other parents to see if any is longer
                    foreach (Shape possibleSuperClass in directSuperClasses.Skip(1))
                    {
                        List<IUriNode> possibleSuperClassParents = possibleSuperClass.LongestSuperClassesPath;
                        if (possibleSuperClassParents.Count() > longestParentPath.Count())
                        {
                            longestParent = possibleSuperClass;
                            longestParentPath = possibleSuperClassParents;
                        }
                    }
                    // At this point longestParentPath + longestParent should together contain the longest path to the root; return them
                    longestParentPath.Add(longestParent.Node);
                    return longestParentPath;
                }
            }
        }

        protected internal Shape(IUriNode node, ShapesGraph graph) {
            _node = node;
            _graph = graph;
        }

        public IUriNode Node
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
        public NodeShape(IUriNode node, ShapesGraph graph): base(node, graph) {
        }
    }
}