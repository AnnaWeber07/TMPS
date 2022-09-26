using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS
{
    class EmployeeVacation : IVacation
    {
        public void FindIfAvailable(DateTime date, Employee employee)
        {
            //int result1 = DateTime.Compare(date1, date2);
            //int result2 = DateTime.Compare(date2, date3);
            //TODO: return info if available

            //if earlier than vacay start -> available
            //if later -> check
            //if earlier than vacay end -> busy
            //if later than vacay end -> available
        }
    }
}
