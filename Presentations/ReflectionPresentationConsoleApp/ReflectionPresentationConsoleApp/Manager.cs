using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionPresentationConsoleApp
{
    public class Manager : Employee
    {
        public int Bonus { get; set; }
        public Manager(string name, double salaryPerHour, int monthHours, int bonus)
            : base(name, salaryPerHour, monthHours)
        {
            Bonus = bonus;
        }

        public double paymentWithBonus()
        {
            return SalaryPerHour * (MonthHours + Bonus);
        }
    }
}
