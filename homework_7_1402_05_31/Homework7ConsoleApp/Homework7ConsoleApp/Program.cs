namespace Homework7ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// Valid Anagram:
            string originalStr = "anagram";
            string anagram = "maaagrn";
            bool anagramResult = Helper.IsAnagram(originalStr, anagram);
            Console.WriteLine($"is anagram? {anagramResult}");

            /// Add Digits:
            int num = 486;
            int addDigitResult = Helper.AddDigits(num);
            Console.WriteLine($"addDigitResult: {addDigitResult}");

            /// Ugly Number:
            int n = 22;
            bool isUglyResult = Helper.IsUgly(n);
            Console.WriteLine($"isUglyResult: {isUglyResult}");


            /// MoveZeroes:
            int[] nums = { 0, 1, 0, 3, 12 };
            Helper.MoveZeroes(nums);
            foreach (int i in nums)
            {
                Console.WriteLine($"element: {i}");
            }

            /// Word Pattern:
            string pattern = "abba";
            string str = "dog dog dog dog";

            var wordPatternResult = Helper.WordPattern(pattern, str);
            Console.WriteLine($"is pattern matched? {wordPatternResult}");

        }
    }
}