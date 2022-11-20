using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    public class Customer
    {
        private string _name;
        private int _age;
        private int _salary;
        private string _occupation;
        private int _creditScore;

        public Customer(string name, int age,
            int salary, string occupation, int creditScore)
        {
            _name = name;
            _age = age;
            _salary = salary;
            _occupation = occupation;
            _creditScore = creditScore;
        }

        public Customer(string name)
        {
            _name = name;
        }

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public int Salary { get { return _salary; } }

        public string Occupation { get { return _occupation; } }
        public int CreditScore { get { return _creditScore; } }


    }
}
