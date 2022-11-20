using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class Possible : Decorator
    {
        protected readonly List<string> possibleClients = new List<string>();
        // Constructor
        public Possible(CreditItem creditItem)
            : base(creditItem)
        {
        }
        public void PossibleCredit(string name)
        {
            possibleClients.Add(name);
            creditItem.Quantity--;
        }
        public void CloseCredit(string name)
        {
            possibleClients.Remove(name);
            creditItem.Quantity++;
        }
        public override void Display()
        {
            base.Display();
            foreach (string possible in possibleClients)
            {
                Console.WriteLine(" possible client: "
                    + possible);
            }
        }
    }
}

