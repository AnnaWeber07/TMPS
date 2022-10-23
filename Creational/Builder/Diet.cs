using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.Builder
{
    public class Diet
    {
        List<object> parts = new List<object>();
        public void Add(string part)
        {
            parts.Add(part);
        }
    }
}
