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
            // returning zero is just a business logic; we decide what to return in such situations.
            return (y != 0) ?  x / y : 0;
        }

        public static double Square(double x)
        {
            if(x < 0)
            {
                throw new ArgumentException("Square only works for positive numbers", "x");
            }

            return Math.Sqrt(x);
        }
    }
}
