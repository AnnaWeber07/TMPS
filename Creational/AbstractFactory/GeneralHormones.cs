using System;

namespace Creational.AbstractFactory
{
    public class GeneralHormones : AbstractProductGeneral
    {
        public override void GenerateCompleteList()
        {
            Console.WriteLine("This is a General Hormones Blood Analysis: ");
        }

        public override void GenerateFullList(GeneralHormones generalHormones)
        {
            GenerateCompleteList();
        }

    }
}