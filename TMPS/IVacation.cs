using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS
{
    interface IVacation
    {
        void FindIfAvailable(DateTime date, Employee employee);
    }
}
