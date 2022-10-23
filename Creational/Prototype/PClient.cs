using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Prototype
{
    public class PClient
    {
        void Operation()
        {
            Prototype prototype = new ConcretePrototypeAnalysis (1);
            Prototype clone = prototype.Clone();
            prototype = new ConcretePrototypeDiet(2);
            clone = prototype.Clone();
        }
    }
}
