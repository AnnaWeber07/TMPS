﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory
{
    public class ConcreteFactoryHormones : AFAnalysis
    {
        //implements the operations to create concrete products
        //concrete analysis checklist for hormones

        public override AbstractAnalysisGeneral CreateProductGeneral()
        {
            return new GeneralHormones();
        }

        public override AbstractProductSpecific CreateProductSpecific()
        {
            return new SpecificHormones();
        }
    }
}
