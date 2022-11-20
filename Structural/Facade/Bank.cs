using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    public class Bank
    {
        
        public bool HasSufficientSavings(Customer customer, int amount)
        {
            Console.WriteLine("Check bank for " + customer.Name);
            if (amount < 0)
            {
                return false;
            }
            return true;
        }

        public int AmountOfSavings(Customer c)
        {
            return (int)(c.Salary * 0.3);
        }

        public int AnnualIncome(Customer customer)
        {
            return customer.Salary;
        }

        public void ClientAnalysis(Customer customer)
        {
            var analysis = AnnualIncome(customer) - AmountOfSavings(customer);

            if (analysis < 0)
            {
                Console.WriteLine("Savings Exceed Income");
            }

            else
            {
                Console.WriteLine("Income Exceeds Savings");
            }

        }

    }
}
