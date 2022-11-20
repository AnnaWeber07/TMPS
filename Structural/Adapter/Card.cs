using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class Card
    {
        protected float dollarCard;
        protected float euroCard;
        protected double cardNumber;
        protected string cardIBAN;
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }
    }
}
