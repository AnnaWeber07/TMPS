using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Creational.FactoryMethod
{
    public class FMDocumentGenerator
    {
        public static void CreateDocument(HospitalDocument[] documents)
        {
            foreach (HospitalDocument document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Subsection section in document.Sections)
                {
                    Console.WriteLine(" " + section.GetType().Name);
                }
            }
        }
    }
}
