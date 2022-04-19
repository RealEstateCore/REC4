using VDS.RDF;
using VDS.RDF.Shacl;
using SHACL2DTDL.VocabularyHelper;
using VDS.RDF.Parsing;

namespace DotNetRdfExtensions
{
    public static class DotNetRdfExtensions
    {
        public static bool ContainsTriple(this IGraph graph, INode subj, INode pred, INode obj) {
            return graph.ContainsTriple(new Triple(subj, pred, obj));
        }

        public static string LocalName(this IUriNode node)
        {
            if (node.Uri.Fragment.Length > 0)
            {
                return node.Uri.Fragment.Trim('#');
            }
            return System.IO.Path.GetFileName(node.Uri.AbsolutePath);
        }

        public static bool IsXsdType(this IUriNode node) {
            return node.Uri.AbsoluteUri.StartsWith(XmlSpecsHelper.NamespaceXmlSchema);
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

        public static IEnumerable<IUriNode> PropertiesThroughRdfsDomain(this IUriNode node) {
            IUriNode rdfsDomain = node.Graph.CreateUriNode(RDFS.domain);
            foreach (Triple t in node.Graph.GetTriplesWithPredicateObject(rdfsDomain, node))
            {
                if (t.Subject.NodeType == NodeType.Uri) {
                    yield return (IUriNode)t.Subject;
                }
            }
        }

        public static IEnumerable<IUriNode> TransitiveRdfTypes(this IUriNode node) {
            IEnumerable<IUriNode> directRdfTypes = node.DirectRdfTypes();
            IEnumerable<IUriNode> superClassesOfDirectRdfTypes = directRdfTypes.SelectMany(rdfType => rdfType.SuperClasses());
            return directRdfTypes.Union(superClassesOfDirectRdfTypes);
        }

        public static IEnumerable<IUriNode> DirectRdfTypes(this IUriNode node) {
            IUriNode rdfType = node.Graph.CreateUriNode(RDF.type);
            return node.Graph.GetTriplesWithSubjectPredicate(node, rdfType).Select(trip => trip.Object).UriNodes();
        }

        public static IEnumerable<IUriNode> SuperClasses(this IUriNode node) {
            IEnumerable<IUriNode> directSuperClasses = node.DirectSuperClasses();
                HashSet<IUriNode> allSuperClasses = new HashSet<IUriNode>();
                allSuperClasses.UnionWith(directSuperClasses);
                foreach (IUriNode superClass in directSuperClasses) {
                    allSuperClasses.UnionWith(superClass.SuperClasses());
                }
                return allSuperClasses;
        }

        public static IEnumerable<IUriNode> DirectSuperClasses(this IUriNode node) {
            IUriNode rdfsSubClassOf = node.Graph.CreateUriNode(RDFS.subClassOf);
            foreach (Triple t in node.Graph.GetTriplesWithSubjectPredicate(node, rdfsSubClassOf))
            {
                if (t.Object.NodeType == NodeType.Uri) {
                    yield return (IUriNode)t.Object;
                }
            }

        }

        public static bool IsObjectProperty(this IUriNode node) {
            return node.TransitiveRdfTypes().Any(rdfType => rdfType.Uri.AbsoluteUri.Equals(OWL.ObjectProperty.AbsoluteUri));
        }

        public static bool IsDataProperty(this IUriNode node) {
            return node.TransitiveRdfTypes().Any(rdfType => rdfType.Uri.AbsoluteUri.Equals(OWL.DatatypeProperty.AbsoluteUri));
        }

        public static IEnumerable<IUriNode> RdfsRanges(this IUriNode node) {
            IUriNode rdfsRange = node.Graph.CreateUriNode(RDFS.range);
            return node.Graph.GetTriplesWithSubjectPredicate(node, rdfsRange).Select(triple => triple.Object).UriNodes();
        }
    }
}