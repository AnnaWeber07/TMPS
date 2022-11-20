using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class NoPercentCredit : CreditItem
    {
        private string client;
        private string reason;
        // Constructor
        public NoPercentCredit(string client, string title, int quantity)
        {
            this.client = client;
            this.reason = title;
            this.Quantity = quantity;
        }
        public override void Display()
        {
            Console.WriteLine("\nCredit with no % ------ ");
            Console.WriteLine(" Client: {0}", client);
            Console.WriteLine(" Reason: {0}", reason);
            Console.WriteLine(" # Quantity: {0}", Quantity);
        }
    }
}
