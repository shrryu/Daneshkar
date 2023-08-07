namespace CustomArrayConsoleApp
{
    internal class Program
    {
        static public int ReverseNumber(int number)
        {
            int numberSign = 1;
            if(number < 0)
            {
                numberSign = -1;
                number *= -1;
            }

            int reversedNumber = 0;

            while(number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            return reversedNumber * numberSign;

        }

        static void Main(string[] args)
        {
            int[] array = { 28, 16, 75, 5, 1, 28};
            int number = -65749;

            int secondMaxNumber = CustomArray.SecondMaxNumber(array);
            int reverseNumber = ReverseNumber(number);
            bool containsDuplicate = CustomArray.FindDuplicate(array);
            string logString = CustomArray.LogString(array);

            Console.WriteLine(logString + " the second max element is: " + secondMaxNumber);
            Console.WriteLine($"reverse of {number} is {reverseNumber}");
            Console.WriteLine(logString + $" duplication is {containsDuplicate}");
        }
    }
}