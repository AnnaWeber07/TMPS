using System;

namespace Creational.AbstractFactory
{
    public class GeneralComplete : AbstractProductGeneral
    {

        public override void GenerateCompleteList()
        {
            Console.WriteLine("This is a Complete General Blood Analysis: ");
        }

        public override void GenerateFullList(GeneralHormones generalHormones)
        {
            Console.WriteLine("This is a Cmoplete General Blood Analysis including Hormones: ");
        }
    }
}