using Creational.AbstractFactory;
using System;

namespace Creational
{
    public class Program
    {
        static void Main(string[] args)
        {
            //in this lab work I've implemented 5 creational patterns

            //AF

            AFAnalysis analysis1 = new ConcreteFactoryComplete();
            AFClient client1 = new AFClient(analysis1);
            client1.Run();

            AFAnalysis analysis2 = new ConcreteFactoryHormones();
            AFClient client2 = new AFClient(analysis2);
            client2.Run();

            Console.ReadKey();
        }
    }
}
