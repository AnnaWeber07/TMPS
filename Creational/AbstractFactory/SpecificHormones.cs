using System;

namespace Creational.AbstractFactory
{
    public class SpecificHormones : AbstractProductSpecific
    {
        public override void GenerateHormonesList()
        {
            Console.WriteLine("This is a Specific Hormones Blood Analysis: ");
        }
    }
}