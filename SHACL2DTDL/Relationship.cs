using VDS.RDF;
using VDS.RDF.Ontology;
using DotNetRdfExtensions;
using DotNetRdfExtensions.SHACL;

namespace SHACL2DTDL
{
    class Relationship {


        public enum RelationshipType {
            Data,
            Object
        }

        public IUriNode Source { get;}
        public IUriNode Property { get; }
        public IUriNode Target { get; }
        public int MaxCardinality { get; set; }
        public int minCardinality { get; set; }
        public RelationshipType Type { get; set; }

        public string Name {
            get {
                return Property.LocalName();
            }
        }

        public Relationship(PropertyShape pShape) {

        }

        public Relationship(OntologyProperty property) {

        }

        public class RelationshipNameComparer: IEqualityComparer<Relationship>
        {
            public bool Equals(Relationship one, Relationship two) {
                return StringComparer.InvariantCultureIgnoreCase.Equals(one.Name, two.Name);
            }

            public int GetHashCode(Relationship item) {
                return StringComparer.InvariantCultureIgnoreCase.GetHashCode(item.Name);
            }
        }
    }
}
