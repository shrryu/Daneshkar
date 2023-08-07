namespace TwoSumPalindromeConsoleApp
{
    internal class Program
    {
        /// <summary>
        /// This method returns indexes of two elements that their sum is equal to target.
        /// it will  return [-1, -1] in case that array does not contains such elements.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        static int[] TwoSum(int[] numbers, int target)
        {
            int[] results = { -1,-1};
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i+1; j < numbers.Length - i; j++)
                {
                    if(numbers[i] + numbers[j] == target)
                    {
                        results[0] = i;
                        results[1] = j;
                        return results;
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// This method returns true if str can be read the same when reversed; otherwise, return false.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static bool IsPalindrome(string str)
        {
            for(int i = 0; i < (str.Length / 2); i++)
            {
                if(str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[] numbers = {2, 7, 11, 15};
            int[] testTwoSum = TwoSum(numbers, 13);
            Console.WriteLine($"Indexes of elements for Two Sum are:[{testTwoSum[0]}, {testTwoSum[1]}]");
            Console.WriteLine($"- is 'radar' a palindrome?\n+ {IsPalindrome("radar")}");
            Console.WriteLine($"- is 'chrome' a palindrome?\n+ {IsPalindrome("chrome")}");
            Console.WriteLine($"- is 'hannah' a palindrome?\n+ {IsPalindrome("hannah")}");
        }
    }
}