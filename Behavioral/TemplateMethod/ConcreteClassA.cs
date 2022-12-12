using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_lab_3.TemplateMethod
{
    public class Categories : CardAccessor
    {
        private List<string> categories;
        public override void Connect()
        {
            categories = new List<string>();
        }
        public override void Select()
        {
            categories.Add("Red");
            categories.Add("Silver");
            categories.Add("Gold");
            categories.Add("Platinum");
            categories.Add("Ultra");
            categories.Add("Kids");
            categories.Add("Black");
        }
        public override void Process(int top)
        {
            Console.WriteLine("Categories ---- ");
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(categories[i]);
            }

            Console.WriteLine();
        }
        public override void Disconnect()
        {
            categories.Clear();
        }
    }
}
