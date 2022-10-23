
using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod
{
    public class DocumentBodySection : Subsection
    {
        public override string Name => "General Info: ";

        public override List<string> Content()
        {
            return new List<string>();
        }
    }
}
