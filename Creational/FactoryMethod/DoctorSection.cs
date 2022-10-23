using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod
{
    public class DoctorSection : Subsection
    {

        List<string> doctors = new List<string>();

        public override string Name => "Dr. Edward Jenner";

        public override List<string> Content()
        {
            Console.WriteLine("Your doctor is: " + Name);
            doctors.Add(Name);

            return new List<string>();
        }
    }
}
