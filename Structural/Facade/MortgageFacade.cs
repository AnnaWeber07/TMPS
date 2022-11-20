using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    public class MortgageFacade
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsElligible(Customer customer, int amount)
        {
            Console.WriteLine($"{customer.Name} applies for {amount} loan\n");
            bool eligible = true;

            //Check the applicant
            if (!bank.HasSufficientSavings(customer, amount))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(customer))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(customer))
            {
                eligible = false;
            }

            return eligible;
        }

    }
}
