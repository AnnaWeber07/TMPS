using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory
{
    public class ConcreteFactoryComplete : AFAnalysis
    {
        //implements the operations to create concrete products
        //concrete analysis checklist for diabetes

        public override AbstractProductGeneral CreateProductGeneral()
        {
            return new GeneralComplete();
        }

        public override AbstractProductSpecific CreateProductSpecific()
        {
            return new SpecificComplete();
        }
    }
}
