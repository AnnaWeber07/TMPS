using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory
{
    public class AFClient
    {
        private AbstractProductGeneral abstractProductGeneral;
        private AbstractProductSpecific abstractProductSpecific;

        public AFClient(AFAnalysis analysis)
        {
            abstractProductGeneral = analysis.CreateProductGeneral();
            abstractProductSpecific = analysis.CreateProductSpecific();
        }

        public void Run()
        {
            abstractProductGeneral.GenerateCompleteList();
            abstractProductSpecific.GenerateHormonesList();
        }

    }

}
