using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_lab_3.Memento
{
    public class Agent
    {
        /*can produce snapshots of its own state,
         as well as restore its state from snapshots when needed*/

        string name;
        string phone;
        double budget;
        // Gets or sets name
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                Console.WriteLine("Name:   " + name);
            }
        }
        // Gets or sets phone
        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                Console.WriteLine("Phone:  " + phone);
            }
        }
        // Gets or sets budget
        public double Salary
        {
            get { return budget; }
            set
            {
                budget = value;
                Console.WriteLine("Salary: " + budget);
            }
        }
        // Stores memento
        public Memento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento(name, phone, budget);
        }
        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Salary = memento.Budget;
        }
    }
}
