using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework7ConsoleApp
{
    public class Helper
    {
        public static bool IsAnagram(string original, string changed)
        {
            if(original.Length != changed.Length)
                return false;

            string tempo = changed;

            for (int i = 0; i < changed.Length;i++)
            {
                var originalCharacter = original[i];
                var occurenceIndex = tempo.IndexOf(originalCharacter);
                if(occurenceIndex != -1)
                {
                    tempo = tempo.Remove(occurenceIndex, 1);
                }
                else
                {
                    return false; 
                }
            }

            return true;
        }

        public static int AddDigits(int num)
        {
            bool oneDigitFlag = false;
            int sum = 0;
            while(!oneDigitFlag)
            {
                sum += (num % 10);
                num /= 10;
                if(num == 0)
                {
                    if(sum /10 == 0)
                    {
                        oneDigitFlag = true;
                    }
                    else
                    {
                        num = sum;
                        sum = 0;
                    }
                }
            }

            return sum;
        }

        public static bool IsUgly(int number)
        {
            if(number < 1)
                return false;

            while (number > 1)
            {
                if(number % 2 == 0)
                {
                    number /= 2;
                }
                else if(number % 3 == 0)
                {
                    number /= 3;
                }
                else if(number % 5 == 0)
                {
                    number /= 5;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        // do it inplace, no copies.
        public static void MoveZeroes(int[] nums)
        {
            int indexOfLastNonZero = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    nums[indexOfLastNonZero++] = nums[i];  
                }
            }

            for (;  indexOfLastNonZero < nums.Length; indexOfLastNonZero++)
            {
                nums[indexOfLastNonZero] = 0;
            }

        }
        public static bool WordPattern(string pattern, string str)
        {
            string[] strSplitted = str.Split(' ');
            if(strSplitted.Length != pattern.Length)
                return false;

            Dictionary<char, string> matchedCharactersWithWords = new ();

            for(int i = 0; i < pattern.Length; i++)
            {
                if(!matchedCharactersWithWords.ContainsKey(pattern[i]))
                {
                    if(!matchedCharactersWithWords.ContainsValue(strSplitted[i]))
                    {
                        matchedCharactersWithWords.Add(pattern[i], strSplitted[i]);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if(matchedCharactersWithWords[pattern[i]] != strSplitted[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }


    }
}
