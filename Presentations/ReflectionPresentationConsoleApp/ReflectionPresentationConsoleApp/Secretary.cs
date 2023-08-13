using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPresentationConsoleApp
{
    public class Secretary : Employee
    {
        public Secretary(string name, double salaryPerHour, int monthHours)
            : base(name, salaryPerHour, monthHours)
        {
            
        }
    }
}
