using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chiriciuc Anna, FAF-201, TMPS Lab nr1. Employee Management Console App
            //TODO: SRP and OCP

            EmployeeList employeeList = new EmployeeList();

            Employee Jane = new Employee("0001", "Jane", 22, 1500, 200,
                                        DateTime.Parse("06/07/2022"), DateTime.Parse("31/07/2022"));
            Employee Josh = new Employee("0002", "Josh", 25, 2100, 100,
                                        DateTime.Parse("07/08/2022"), DateTime.Parse("31/08/2022"));
            Employee Adriana = new Employee("0003", "Adriana", 25, 2100, 100,
                                        DateTime.Parse("07/08/2022"), DateTime.Parse("31/08/2022"));
            Employee Maxim = new Employee("0004", "Maxim", 31, 3000, 500,
                                        DateTime.Parse("01/09/2022"), DateTime.Parse("20/09/2022"));
            Employee Alex = new Employee("0005", "Alex", 20, 1000, 300,
                                        DateTime.Parse("01/10/2022"), DateTime.Parse("10/10/2022"));

            EmployeeList employee = new EmployeeList();
            employeeList.AddEmployee(Jane);
            employeeList.AddEmployee(Josh);
            employeeList.AddEmployee(Adriana);
            employeeList.AddEmployee(Maxim);
            employeeList.AddEmployee(Alex);

            //Get an employee:
            //Console.WriteLine("Enter ID:");
            //var byId = Console.ReadLine();
            //employeeList.Show(byId);

            //Create an employee:
            Console.WriteLine("Enter valid employee info delimited by enter:");
            Console.WriteLine("ID, Name, Age, Salary, Premium, Vacation Start&End DD/MM/YYYY:");
            string parse = Console.ReadLine();

            employeeList.GenerateEmployee(parse);


        }
    }
}
