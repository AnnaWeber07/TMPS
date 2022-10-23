using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod
{
    public abstract class Subsection
    {
        public abstract string Name { get; }
        public abstract List<string> Content();
    }
}
