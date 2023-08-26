using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework7ConsoleApp;
using Xunit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork7ConsoleApp.Test
{
    public class HelperTests
    {
        [Fact]
        public void IsAnagram_LettersShouldMatch()
        {
            // Arrange:
            bool expected = true;

            // Act:
            bool actual = Helper.IsAnagram("anagram", "nagrama");

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10848, 3)]
        [InlineData(38, 2)]
        [InlineData(879, 6)]
        [InlineData(5, 5)]
        [InlineData(0, 0)]
        public void AddDigits(int number, int expected)
        {
            // Act:
            double actual = Helper.AddDigits(number);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(14, false)]
        [InlineData(6, true)]
        [InlineData(-74, false)]
        [InlineData(1, true)]
        [InlineData(435, false)]
        public void IsUgly(int number, bool expected)
        {
            // Act:
            bool actual = Helper.IsUgly(number);

            // Assert:
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        [InlineData(new int[] { 0, 1, 0, 0, 54, 1 }, new int[] { 1, 54, 1, 0, 0, 0 })]
        public void MoveZeroes(int[] nums, int[] expected)
        {
            // Act:
            Helper.MoveZeroes(nums);

            // Assert:
            Assert.Equal(expected, nums);
        }

        [Theory]
        [InlineData("abba", "dog dog dog dog", false)]
        [InlineData("abba", "dog cat cat dog", true)]
        [InlineData("aaaa", "dog cat cat dog", false)]
        [InlineData("aaaa", "cat cat cat dog", false)]
        [InlineData("aaaa", "cat cat cat cat", true)]
        public void WordPattern(string pattern, string str, bool expected)
        {
            // Act:
            bool actual = Helper.WordPattern(pattern, str);

            // Assert:
            Assert.Equal(expected, actual);
        }
        
    }
}
