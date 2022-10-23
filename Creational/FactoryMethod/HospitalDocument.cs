using System.Collections.Generic;

namespace Creational.FactoryMethod
{
    public abstract class HospitalDocument
    {
        private List<Subsection> _subsections = new List<Subsection>();
        // Constructor calls abstract Factory method
        public HospitalDocument()
        {
            this.CreateDocs();
        }
        public List<Subsection> Subsections
        {
            get { return _subsections; }
        }
        // Factory Method
        public abstract void CreateDocs();
    }
}
