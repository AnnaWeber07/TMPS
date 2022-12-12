using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS_lab_3.Iterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
