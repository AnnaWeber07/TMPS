using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class PersonalEmployee : CreditItem
    {
        private string employee;
        private string reason;
        private int timeGiven;
        // Constructor
        public PersonalEmployee(string employee, string reason, int quantity, int timeGiven)
        {
            this.employee = employee;
            this.reason = reason;
            this.Quantity = quantity;
            this.timeGiven = timeGiven;
        }
        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Employee: {0}", employee);
            Console.WriteLine(" Reason: {0}", reason);
            Console.WriteLine(" Quantity: {0}", Quantity);
            Console.WriteLine(" Playtime: {0}\n", timeGiven);
        }
    }
}
