using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod
{
    public class Report : HospitalDocument
    {
        public override void CreateDocs()
        {
            Subsections.Add(new DoctorSection());
            Subsections.Add(new AnalysisSection());
        }
    }
}
