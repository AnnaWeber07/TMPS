using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory
{
    public abstract class AFAnalysis
    {
        //declares an interface for operations that create abstract products
        //implemented analysis list for diabetes and hormones
        
        public abstract AbstractAnalysisGeneral CreateProductGeneral();
        public abstract AbstractProductSpecific CreateProductSpecific();

    }
}
