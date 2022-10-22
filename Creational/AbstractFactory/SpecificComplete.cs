using System;

namespace Creational.AbstractFactory
{
    public class SpecificComplete : AbstractProductSpecific
    {
        public override void GenerateHormonesList()
        {
            Console.WriteLine("This is a Specific Blood Analysis: ");
        }
    }
}