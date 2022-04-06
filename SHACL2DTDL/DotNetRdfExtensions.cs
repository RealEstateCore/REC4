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

        public static bool IsNodeShape(this INode node) {
            IGraph graph = node.Graph;
            IUriNode rdfType = graph.CreateUriNode(RDF.type);
            IUriNode shNodeShape = graph.CreateUriNode(SH.NodeShape);
            return graph.ContainsTriple(new Triple(node, rdfType, shNodeShape));
        }

        public static string LocalName(this IUriNode node)
        {
            if (node.Uri.Fragment.Length > 0)
            {
                return node.Uri.Fragment.Trim('#');
            }
            return System.IO.Path.GetFileName(node.Uri.AbsolutePath);
        }

        public static IEnumerable<ILiteralNode> RdfsLabels(this INode node) {
            IUriNode rdfsLabel = node.Graph.CreateUriNode(RDFS.label);
            foreach (Triple t in node.Graph.GetTriplesWithSubjectPredicate(node, rdfsLabel))
            {
                if (t.Object.NodeType == NodeType.Literal) {
                    yield return (ILiteralNode)t.Object;
                }
            }
        }

         public static IEnumerable<ILiteralNode> RdfsComments(this INode node) {
            IUriNode rdfsComment = node.Graph.CreateUriNode(RDFS.comment);
            foreach (Triple t in node.Graph.GetTriplesWithSubjectPredicate(node, rdfsComment))
            {
                if (t.Object.NodeType == NodeType.Literal) {
                    yield return (ILiteralNode)t.Object;
                }
            }
        }
    }

    public class Shape: IEquatable<Shape>  {
        /// <summary>
        /// The Node which this Shape is a wrapper around.
        /// </summary>
        protected INode _node;
        /// <summary>
        /// The Graph from which this Shape originates.
        /// </summary>
        protected ShapesGraph _graph;


        // Implementation of IEquatable<T> interface
        public bool Equals(Shape? shape)
        {
            return this.Node == shape?.Node;
        }

        public IUriNode? NodeKind {
            get {
                IUriNode shNodeKind = _graph.CreateUriNode(SH.nodeKind);
                return _graph.GetTriplesWithSubjectPredicate(_node, shNodeKind).Select(trip => trip.Object).UriNodes().FirstOrDefault();
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

        // TODO: Implement this to capture deprecation annotations (which ones?)
        public bool IsDeprecated 
        {
            get 
            {
                return false;
            }
        }
    }

    public class  NodeShape: Shape {
        public NodeShape(IUriNode node, ShapesGraph graph): base(node, graph) {
        }

        public IEnumerable<PropertyShape> PropertyShapes {
            get {
                IUriNode shProperty = _graph.CreateUriNode(SH.property);
                foreach (Triple t in _graph.GetTriplesWithSubjectPredicate(_node, shProperty))
                {
                    // TODO: should we perhaps specialize propertyshapes into subclasses based on property path type?
                    yield return new PropertyShape(t.Object, _graph);
                }
            }
        }

        public IEnumerable<NodeShape> DirectSuperClasses {
            get {
                IUriNode rdfsSubClassOf = _graph.CreateUriNode(RDFS.subClassOf);
                foreach (Triple t in _graph.GetTriplesWithSubjectPredicate(_node, rdfsSubClassOf))
                {
                    if (t.Object.NodeType == NodeType.Uri && t.Object.IsNodeShape()) {
                        yield return new NodeShape((IUriNode)t.Object, _graph);
                    }
                }
            }
        }

        public IEnumerable<NodeShape> SuperClasses {
            get {
                IEnumerable<NodeShape> directSuperClasses = this.DirectSuperClasses;
                HashSet<NodeShape> allSuperClasses = new HashSet<NodeShape>();
                allSuperClasses.UnionWith(directSuperClasses);
                foreach (NodeShape superClass in directSuperClasses) {
                    allSuperClasses.UnionWith(superClass.SuperClasses);
                }
                return allSuperClasses;
            }
        }

        public IEnumerable<NodeShape> DirectSubClasses {
            get {
                IUriNode rdfsSubClassOf = _graph.CreateUriNode(RDFS.subClassOf);
                foreach (Triple t in _graph.GetTriplesWithPredicateObject(rdfsSubClassOf,_node))
                {
                    if (t.Subject.NodeType == NodeType.Uri) {
                        yield return new NodeShape((IUriNode)t.Subject, _graph);
                    }
                }
            }
        }

        public IEnumerable<NodeShape> SubClasses {
            get {
                IEnumerable<NodeShape> directSubClasses = this.DirectSubClasses;
                HashSet<NodeShape> allSubClasses = new HashSet<NodeShape>();
                allSubClasses.UnionWith(directSubClasses);
                foreach (NodeShape subClass in directSubClasses) {
                    allSubClasses.UnionWith(subClass.SubClasses);
                }
                return allSubClasses;
            }
        }

        public List<IUriNode> LongestSuperClassesPath {
            get {
                IEnumerable<NodeShape> directSuperClasses = this.DirectSuperClasses;
                if (directSuperClasses.Count() < 1 || directSuperClasses.Any(superClass => superClass.IsTopThing)) {
                    return new List<IUriNode>();
                }
                else {
                    // Assume the first parent has the longest path; if not, it will be replaced in subsequent foreach
                    NodeShape longestParent = directSuperClasses.First();
                    List<IUriNode> longestParentPath = longestParent.LongestSuperClassesPath;
                     // Iterate through the other parents to see if any is longer
                    foreach (NodeShape possibleSuperClass in directSuperClasses.Skip(1))
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

        new public IUriNode Node
        {
            get
            {
                return (IUriNode)_node;
            }
        }

        public bool IsTopThing
        {
            get {
                string[] topLevelThings = {
                    OWL.Thing.AbsoluteUri,
                    RDFS.Resource.AbsoluteUri
                };
                return topLevelThings.Contains(Node.Uri.AbsoluteUri);
            }            
        }
    }

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