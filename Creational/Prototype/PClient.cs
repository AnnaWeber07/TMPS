using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Prototype
{
    public class PClient
    {
        void Operation()
        {
            Prototype prototype = new ConcretePrototype1(1);
            Prototype clone = prototype.Clone();
            prototype = new ConcretePrototype2(2);
            clone = prototype.Clone();
        }
    }
}
