using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Prototype
{
    public class ConcretePrototypeDiet : Prototype
    {
        public ConcretePrototypeDiet(int id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            return new ConcretePrototypeDiet(Id);
        }
    }
}
