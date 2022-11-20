using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class InternetBanking
    {
        // The databank 'legacy API'
        public float GetCardInfo(string compound, string point)
        {
            // Euro
            if (point == "E")
            {
                switch (compound.ToLower())
                {
                    case "first": return 6543.4f;
                    case "second": return 35.5f;
                    case "third": return -114.1f;
                    default: return 0f;
                }
            }
            // Dollar
            else
            {
                switch (compound.ToLower())
                {
                    case "first": return 140.0f;
                    case "second": return 86.1f;
                    case "third": return 7.3f;
                    default: return 0f;
                }
            }
        }
        public string GetIBAN(string compound)
        {
            switch (compound.ToLower())
            {
                case "first": return "ARG76543983298";
                case "second": return "ARG68209487239";
                case "third": return "ARG79505093509";
                default: return "";
            }
        }
        public double GetCardNumber(string compound)
        {
            switch (compound.ToLower())
            {
                case "first": return 363672;
                case "second": return 579283;
                case "third": return 111832;
                default: return 0d;
            }
        }
    }
}
