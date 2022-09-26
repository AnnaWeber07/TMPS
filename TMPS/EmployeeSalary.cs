using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS
{
    class EmployeeSalary : ISalary
    {
        //OCP

        public void RaiseSalary(List<Employee> employees, string id, int howMuch)
        {

            Employee e = (Employee)employees.Where(x => x.ID == id);
            e.Salary = +howMuch;

            Console.WriteLine("Salary raised!");
        }


        public void NewYearRaise(List<Employee> employees, Employee e, string id)
        {
            double newYearGift = 300;

            if (e.ID == id && employees.Contains(e))
            {
                e.Salary += newYearGift;
            }

            Console.WriteLine("New Year Premium added!");
        }

        public void PenaltySystem()
        {
            throw new NotImplementedException();
        }

    }
}
