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

        [Theory] // 'Theory decorator says that we have data set(s) that we want to test.
        [InlineData(32, 77, 109)] // 'InlineData' decorator is for giving method's inputs and we can use it multiple times.
        [InlineData(-21, 76, 55)] 
        [InlineData(98.87, 675.454, 774.324)] 
        public void Add_SimpleValuesShouldCalculateWithTheory(double x, double y, double expected)
        {
            // Act:
            double actual = SimpleCalculator.Add(x, y);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(16, 4, 4)]
        [InlineData(176, 2, 88)]
        public void Divide_SimpleValuesShouldCalculateWithTheory(double x, double y, double expected)
        {
            // Act:
            double actual = SimpleCalculator.Divide(x, y);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Divide_DivideByZero()
        {
            // Arrange:
            double expected = 0;

            // Act:
            double actual = SimpleCalculator.Divide(83, 0);

            // Assert: 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Square_ValueMustbePositive()
        {
            Assert.Throws<ArgumentException>("x", () => SimpleCalculator.Square(-21));
        }
    }
}
