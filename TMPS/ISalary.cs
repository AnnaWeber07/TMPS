using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS
{
    interface ISalary
    {
        void NewYearRaise(List<Employee> employees, Employee e, string id);
        void RaiseSalary(List<Employee> employees, string id, int howMuch);
        void PenaltySystem();
    }
}
