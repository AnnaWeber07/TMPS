using Creational.AbstractFactory;
using Creational.Builder;
using Creational.FactoryMethod;
using System;

namespace Creational
{
    public class Program
    {
        static void Main(string[] args)
        {
            //in this lab work I've implemented 5 creational patterns

            //AF - generating 2 types of blood analysis list,
            //complete and specific ones. Separated by logical analysis sections


            AFAnalysis analysis1 = new ConcreteFactoryComplete();
            AFClient client1 = new AFClient(analysis1);
            client1.Run();

            AFAnalysis analysis2 = new ConcreteFactoryHormones();
            AFClient client2 = new AFClient(analysis2);
            client2.Run();

            //FM - report composition based on several subsections
            //such as doctor's name, document body section, analysis and conclusion
            //full report and basic report versions

            HospitalDocument[] hospitalDocument = new HospitalDocument[2];

            hospitalDocument[0] = new FullReport();
            hospitalDocument[1] = new Report();

            FMDocumentGenerator.CreateDocument(hospitalDocument);

            //Builder - a pattern to build diets (depending on diagnosis)

            ConcreteBuilder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Diet diet = builder.GetResult();

            //Prototype - clone needed data by id without giving direct access


            //Singleton - provide access to any other important stuff as a global variable


            Console.ReadKey();
        }
    }
}
