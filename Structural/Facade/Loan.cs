using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    public class Loan
    {


        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);

            if (c.CreditScore > c.Salary)
            {
                return false;
            }

            return true;
        }
    }
}
