using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder
{
    public class ConcreteBuilder : Builder
    {
        Diet diet = new Diet();

        public override void BuildPartA()
        {
            diet.Add("Diet for diabetes: ");
        }

        public override void BuildPartB()
        {
            diet.Add("Diet for losing weight: ");
        }

        public override void BuildPartC()
        {
            diet.Add("Cardiac diet: ");
        }

        public override Diet GetResult()
        {
            return diet;
        }
    }
}
