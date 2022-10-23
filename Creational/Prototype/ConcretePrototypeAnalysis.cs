using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Prototype
{
    public class ConcretePrototypeAnalysis : Prototype
    {
        public ConcretePrototypeAnalysis(int id) : base(id)
        {

        }

        public override Prototype Clone()
        {
            return new ConcretePrototypeAnalysis(Id);
        }
    }
}
