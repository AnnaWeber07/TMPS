using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_lab_3.TemplateMethod
{
    public class Currency : CardAccessor
    {
        private List<string> currency;
        public override void Connect()
        {
            currency = new List<string>();
        }
        public override void Select()
        {
            currency.Add("Euro Card");
            currency.Add("Dollar Card");
            currency.Add("Tenge");
            currency.Add("Moldavian Lei");
            currency.Add("Romanian Lei");
            currency.Add("Russian Rubles");
            currency.Add("Japanese Yen");
        }
        public override void Process(int top)
        {
            Console.WriteLine("Currency ---- ");
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(currency[i]);
            }
            Console.WriteLine();
        }
        public override void Disconnect()
        {
            currency.Clear();
        }
    }
}
