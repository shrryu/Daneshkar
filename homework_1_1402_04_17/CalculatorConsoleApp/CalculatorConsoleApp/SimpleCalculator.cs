using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    public static class SimpleCalculator
    {
        private static double piNum = 3.14;

        public static double AddToPi(double entry)
        {
            return piNum + entry;
        }
        public static double Add(double x, double y) 
        {
            return x + y;
        }

        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
