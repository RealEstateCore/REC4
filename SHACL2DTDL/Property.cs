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

        public IUriNode Source { get;}
        public IUriNode WrappedProperty { get; }
        public IUriNode Target { get; }
        public int? MaxCardinality { get; set; }
        public int? minCardinality { get; set; }
        public PropertyType Type { get; set; }

        public string Name {
            get {
                return WrappedProperty.LocalName();
            }
        }

        public Property(PropertyShape pShape) {

        }

        public Property(OntologyProperty property) {

        }

        public class PropertyNameComparer: IEqualityComparer<Property>
        {
            public bool Equals(Property one, Property two) {
                return StringComparer.InvariantCultureIgnoreCase.Equals(one.Name, two.Name);
            }

            public int GetHashCode(Property item) {
                return StringComparer.InvariantCultureIgnoreCase.GetHashCode(item.Name);
            }
        }
    }
}
