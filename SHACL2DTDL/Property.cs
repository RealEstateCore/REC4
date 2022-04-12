using VDS.RDF;
using VDS.RDF.Ontology;
using DotNetRdfExtensions;
using DotNetRdfExtensions.SHACL;

namespace SHACL2DTDL
{
    class Property {


        public enum PropertyType {
            Data,
            Object
        }

        public IUriNode WrappedProperty { get; }
        public IUriNode? Target { get; }
        public int? MaxCardinality { get; set; }
        public int? MinCardinality { get; set; }
        public PropertyType Type { get; set; }

        public string Name {
            get {
                return WrappedProperty.LocalName();
            }
        }

        // TODO: Support different types of property paths, see https://www.w3.org/TR/shacl/#property-paths 
        // (currently we only support simple ) predicate paths, i.e., where ps.Path.NodeType = NodeType.Uri
        public Property(PropertyShape pShape) {
            // Set WrappedProperty
            if (pShape.Path is not IUriNode) {
                throw new ArgumentException($"Property path {pShape.Path} is not a URI node");
            }
            WrappedProperty = (IUriNode)pShape.Path;

            // Set Type & Target
            if (pShape.Datatype is IUriNode || (pShape.NodeKind is IUriNode nodeKind1 && nodeKind1.LocalName() == "Literal")) {
                Type = PropertyType.Data;
                // Note: pShape.Datatype can be null
                Target = pShape.Datatype;
            }
            else if (pShape.Class.FirstOrDefault() is IUriNode || pShape.NodeKind is IUriNode nodeKind2 && nodeKind2.LocalName() == "IRI") {
                Type = PropertyType.Object;
                // Note: pShape.Class.FirstOrDefault() can be null
                Target = pShape.Class.FirstOrDefault();
            }

            // Set cardinality
            // Note: both of these can be null
            MinCardinality = pShape.MinCount;
            MaxCardinality = pShape.MaxCount;
        }

        public Property(OntologyProperty property) {
            // Set WrappedProperty
            if (property.Resource is not IUriNode) {
                throw new ArgumentException($"Property path {property.Resource} is not a URI node");
            }
            WrappedProperty = (IUriNode)property.Resource;
            
            // TODO: Set Target
            // TODO: Set cardinality
        }

        public class PropertyNameComparer: IEqualityComparer<Property>
        {
            public bool Equals(Property? one, Property? two) {
                if (one is null || two is null) {
                    return false;
                }
                return StringComparer.InvariantCultureIgnoreCase.Equals(one.Name, two.Name);
            }

            public int GetHashCode(Property item) {
                return StringComparer.InvariantCultureIgnoreCase.GetHashCode(item.Name);
            }
        }
    }
}
