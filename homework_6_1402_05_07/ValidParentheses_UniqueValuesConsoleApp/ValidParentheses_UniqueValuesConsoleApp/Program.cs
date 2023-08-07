namespace ValidParentheses_UniqueValuesConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            Console.WriteLine(Helper.CountUniqueItems(numbers));

            string chars = "hsdf(fei[(sdfmdsi)]sd)asd";
            //char[] chars = { '[' , ')','(',']' };

            Console.WriteLine(Helper.IsValid(chars));
        }
    }
}