using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_lab_3.TemplateMethod
{
    public abstract class CardAccessor
    {
        public abstract void Connect();
        public abstract void Select();
        public abstract void Process(int top);
        public abstract void Disconnect();
        // The 'Template Method' 
        public void Run(int top)
        {
            Connect();
            Select();
            Process(top);
            Disconnect();
        }
    }
}
