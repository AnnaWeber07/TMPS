using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod
{
    public class FullReport : HospitalDocument
    {
        public override void CreateDocs()
        {
            Subsections.Add(new DoctorSection());
            Subsections.Add(new DocumentBodySection());
            Subsections.Add(new AnalysisSection());
            Subsections.Add(new ConclusionSection());
        }
    }
}
