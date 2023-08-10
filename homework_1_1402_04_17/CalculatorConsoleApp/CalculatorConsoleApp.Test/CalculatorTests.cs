using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorConsoleApp;
using Xunit;

namespace CalculatorConsoleApp.Test
{
    public class CalculatorTests
    {
        [Fact] // 'Fact' decorator says that this is a test and I want you to run it in test runner
        public void Add_SimpleValuesShouldCalculate()
        {
            // Arrange:
            double expected = 5;

            // Act:
            double actual = SimpleCalculator.Add(3, 2);

            // Assert:
            Assert.Equal(expected, actual);
        }
    }
}
