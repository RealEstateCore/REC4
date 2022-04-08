using VDS.RDF;

namespace SHACL2DTDL
{
    class Relationship {

        public IUriNode Source { get;}
        public IUriNode Target { get; }
        public int MaxCardinality { get; set; }
        public int minCardinality { get; set; }

    }
}
