using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_lab_3.Memento
{
    public class MemoryLoader
    {
        /*Kbows not only "when" and "why" to capture the
         originator's state, but also when the state should be restored
         stores a stack of mementos */

        Memento memento;

        public Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
