using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPresentationConsoleApp
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double SalaryPerHour { get; set; }
        public int MonthHours { get; set; }

        public Employee(string name, double salaryPerHour, int monthHours)
        {
            Name = name;
            SalaryPerHour = salaryPerHour;
            MonthHours = monthHours;
        }

        public double payment()
        {
            return SalaryPerHour * MonthHours;
        }
    }
}
