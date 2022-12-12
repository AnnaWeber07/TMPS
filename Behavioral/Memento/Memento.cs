using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_lab_3.Memento
{
    public class Memento
    {
        /*is a value object that acts as a snapshot of the originator's state.
         It's a common practice to make the memento immutable and pass it the
        data only once, via the ctor 
        
         memento is nested inside the originator */

        string name;
        string phone;
        double budget;
        // Constructor
        public Memento(string name, string phone, double budget)
        {
            this.name = name;
            this.phone = phone;
            this.budget = budget;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
    }
}
