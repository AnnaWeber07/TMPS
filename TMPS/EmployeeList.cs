using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS
{
    class EmployeeList
    {
        public List<Employee> employees = new List<Employee>();

        public List<Employee> AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        public List<Employee> RemoveEmployee(Employee employee)
        {
            var itemToRemove = employees.SingleOrDefault(x => x.ID == employee.ID);
            employees.Remove(itemToRemove);

            return employees;
        }

        public void GenerateEmployee(string parse)
        {
            var result = parse.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            var id = result[0];
            var name = result[1];
            var age = Int32.Parse(result[2]);
            var salary = Int32.Parse(result[3]);
            var premium = Int32.Parse(result[4]);
            var vacayStart = DateTime.Parse(result[5]);
            var vacayEnd = DateTime.Parse(result[6]);

            Employee employee = new Employee(id, name, age, salary, premium, vacayStart, vacayEnd);
            AddEmployee(employee);
        }

        public void Show(string id)
        {
            Employee e = (Employee)employees.Where(x => x.ID == id);
            Console.WriteLine(e.ID, e.Name, e.Age, e.Salary, e.Premium);
        }
    }
}
