using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class Decorator : CreditItem
    {
        protected CreditItem creditItem;
        // Constructor
        public Decorator(CreditItem libraryItem)
        {
            this.creditItem = libraryItem;
        }
        public override void Display()
        {
            creditItem.Display();
        }
    }
}
