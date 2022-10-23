using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod
{
    public class ConclusionSection : Subsection
    {
        public override string Name => "Conclusion: ";

        public override List<string> Content()
        {
            return new List<string>();
        }
    }
}
