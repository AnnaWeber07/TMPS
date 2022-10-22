using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory
{
    public class ConcreteFactoryHormones : AFAnalysis
    {
        public override AbstractProductGeneral CreateProductGeneral()
        {
            return new GeneralHormones();
        }

        //implements the operations to create concrete products
        //concrete analysis checklist for hormones

        public override AbstractProductSpecific CreateProductSpecific()
        {
            return new SpecificHormones();
        }
    }
}
