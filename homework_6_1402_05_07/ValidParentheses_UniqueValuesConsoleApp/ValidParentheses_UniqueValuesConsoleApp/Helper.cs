namespace ValidParentheses_UniqueValuesConsoleApp
{
    internal class Helper
    {
        /// <summary>
        /// This method checks if a string has valid sets of parentheses or not.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsValid(string str)
        {
            return IsValid(str.ToCharArray());
        }
        /// <summary>
        /// This method checks if an array of chars has valid sets of parentheses or not.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsValid(char[] str)
        {
            Stack<char> stack = new Stack<char>();
            char[] parentheses = { '(', '[', '{', ')', ']','}'};

            foreach (char character in str)
            {
                if(!parentheses.Contains(character))
                    continue;
                if(character == '{' || character == '[' || character == '(')
                {
                    stack.Push(character);
                }
                else
                {
                    if(!stack.Any())
                    {
                        return false;
                    }
                    char stackTop = stack.Peek();
                    if((character == ')' && stackTop == '(') ||
                       (character == '}' && stackTop == '{') ||
                       (character == ']' && stackTop == '['))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        /// <summary>
        /// This method takes an ascending-sorted array and returns number of unique values of it or 0 if array is empty.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int CountUniqueItems(int[] numbers)
        {
            if(numbers.Length <= 0)
            {
                return 0;
            }
            int count = 1;
            //int[] uniques = new int[numbers.Length];
            //uniques[0] = numbers[0];
            
            for(int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] != numbers[i -1])
                    count++;
                    //uniques[++count] = numbers[i];
            }

            return count;
        }

        //public static int CountUniqueItems<T>(T[] numbers) where T : struct, IConvertible, IComparable
        //public static int CountUniqueItems<T>(List<T> numbers) where T : struct, IConvertible, IComparable
        //{
        //    if(numbers.Count <= 0)
        //    {
        //        return -1;
        //    }
        //    int count = 1;
        //    List<T> uniques = new List<T>(); 
        //    //T[] uniques = new T[numbers.Count];
        //    uniques.Add(numbers[0]);

        //    for(int i = 0; i < numbers.Count; i++)
        //    {
        //        bool isUnique = true;
        //        for(int j = 0; j <= i; j++)
        //        {
        //            T temp1 = uniques[j];
        //            T temp2 = numbers[i];
        //            if(temp1 == temp2)
        //                isUnique = false;
        //        }
        //        if(isUnique)
        //        {
        //            uniques[++count] = numbers[i];
        //        }
        //    }

        //    return count;
        //}
    }
}
