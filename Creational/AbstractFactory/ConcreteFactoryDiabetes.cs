using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory
{
    public class ConcreteFactoryDiabetes : AFAnalysis
    {
        //implements the operations to create concrete products
        //concrete analysis checklist for diabetes

        public override AbstractAnalysisGeneral CreateProductGeneral()
        {
            return new GeneralDiabetes();
        }

        public override AbstractProductSpecific CreateProductSpecific()
        {
            return new SpecificDiabetes();
        }
    }
}
