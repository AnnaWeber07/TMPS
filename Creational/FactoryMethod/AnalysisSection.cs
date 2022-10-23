using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod
{
    public class AnalysisSection : Subsection
    {
        public override string Name => "This is the Analysis Section: ";

        public override List<string> Content()
        {
            return new List<string>();
        }
    }
}
