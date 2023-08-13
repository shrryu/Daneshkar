using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPresentationConsoleApp
{
    public class Accountant : Employee
    {
        public Accountant(string name, double salaryPerHour, int monthHours) 
            : base(name, salaryPerHour, monthHours)
        {
            
        }
    }
}
