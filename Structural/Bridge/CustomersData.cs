using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public class CustomersData : DataObject
    {
        private readonly List<string> customers = new List<string>();
        private int current = 0;
        private string city;
        public CustomersData(string city)
        {
            this.city = city;
            // Loaded from a database 
            customers.Add("P.D. Jenkins");
            customers.Add("S.A. Jackie");
            customers.Add("A.P. Goodwin");
            customers.Add("A.A. Stein");
            customers.Add("L.L. Giovanni");
        }
        public override void LatterRecord()
        {
            if (current <= customers.Count - 1)
            {
                current++;
            }
        }
        public override void FormerRecord()
        {
            if (current > 0)
            {
                current--;
            }
        }
        public override void AddRecord(string customer)
        {
            customers.Add(customer);
        }
        public override void DeleteRecord(string customer)
        {
            customers.Remove(customer);
        }
        public override string GetCurrentRecord()
        {
            return customers[current];
        }
        public override void ShowRecord()
        {
            Console.WriteLine(customers[current]);
        }
        public override void ShowAllRecords()
        {
            Console.WriteLine("Customer City: " + city);
            foreach (string customer in customers)
            {
                Console.WriteLine(" " + customer);
            }
        }
    }
}
