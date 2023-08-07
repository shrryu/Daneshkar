namespace FibonacciConsoleApp
{
    internal class Program
    {
        private static long Fibonacci(in long fiboIndex)
        {
            if(fiboIndex < 0)
            {
                return -1;
            }
            
            if(fiboIndex == 0 || fiboIndex == 1)
            {
                return fiboIndex;
            }

            long firstElement = 0;
            long secondElement = 1;
            for(int i = 2; i <= fiboIndex; i++)
            {
                long temp = firstElement;
                firstElement = secondElement;
                secondElement += temp;
            }
            return secondElement;
        }

        private static long RecursiveFibonacci(in long fiboIndex)
        {
            if(fiboIndex < 0)
            {
                return -1;
            }

            if(fiboIndex == 0 || fiboIndex == 1)
            {
                return fiboIndex;
            }
            else
            {
                return RecursiveFibonacci(fiboIndex - 1) + RecursiveFibonacci(fiboIndex - 2);
            }

        }

        private static List<long> FibonacciSequence(in long fiboIndex)
        {
            List<long> fiboList = new();
            if(fiboIndex < 0)
            {
                return fiboList;
            }

            fiboList.Add(0);
            switch(fiboIndex)
            {
            
                case 0:
                    break;
                case 1:
                    fiboList.Add(1);
                    break;
                default:
                    fiboList.Add(1);
                    for(int i = 2; i < fiboIndex; i++)
                    {
                        fiboList.Add(fiboList[i-1] + fiboList[i-2]);
                    }
                    break;
            }

            return fiboList;
        }

        static void Main(string[] args)
        {
            const long fiboIndex = 20; 
            for(int i = 0; i < fiboIndex; i++)
            {
                Console.WriteLine("normal fibo at "+ i + " equals to: " + Fibonacci(i));
                Console.WriteLine("recursive fibo at " + i + " equals to: " + RecursiveFibonacci(i));
            }

            string FiboSequenceStr = $"fibonacci elements till index of {fiboIndex} are: ";
            foreach(long fiboNumber in FibonacciSequence(fiboIndex))
            {
                FiboSequenceStr += fiboNumber.ToString() + ", ";
            }
            Console.WriteLine(FiboSequenceStr.Remove(FiboSequenceStr.Length - 2));
        }
    }
}