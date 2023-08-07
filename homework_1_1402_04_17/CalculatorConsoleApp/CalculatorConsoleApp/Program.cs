namespace CalculatorConsoleApp
{
    internal class Program
    {

        private static decimal CheckEntry(string? Entry, out bool Status)
        {
            bool IsEntryNullOrEmpty = string.IsNullOrEmpty(Entry);
            if(IsEntryNullOrEmpty)
            {
                Console.WriteLine("your entry is null or empty; please enter a number next time.");
                Status = false;
                return decimal.Zero;
            }

            if(Entry == "exit")
            {
                Environment.Exit(1);
            }

            decimal Number;
            bool IsEntryANumber = decimal.TryParse(Entry, out Number);
            if(!IsEntryANumber)
            {
                Console.WriteLine("your entry is not a number; please enter a number next time.");
                Status = false;
                return decimal.Zero;
            }

            Status = true;
            return Number;
        }

        private static void ShowCalculationResult(decimal FirstNumber, decimal SecondNumber, string Operator, decimal result)
        {
            string output = $"{FirstNumber} {Operator} {SecondNumber} = {result}";
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("enter 'exit' to close the app at any time.");
                bool EntryStatus;
                // first entry:
                Console.WriteLine("Enter your first number: ");
                string? FirstEntry = Console.ReadLine();
                decimal FirstNumber = CheckEntry(FirstEntry, out EntryStatus);
                if(!EntryStatus)
                {
                    continue;
                }

                // second entry:
                Console.WriteLine("Enter your second number: ");
                string? SecondEntry = Console.ReadLine();
                decimal SecondNumber = CheckEntry(SecondEntry, out EntryStatus);
                if(!EntryStatus)
                {
                    continue;
                }

                // operator:
                Console.WriteLine("Enter your operator: ");
                string? Operator = Console.ReadLine();

                if(string.IsNullOrEmpty(Operator))
                {
                    Console.WriteLine("your third entry is null or empty; please enter an operator next time.");
                    continue;
                }
                if(Operator == "exit")
                {
                    Environment.Exit(1);
                }
                if(Operator == "+")
                {
                    ShowCalculationResult(FirstNumber, SecondNumber, Operator, FirstNumber + SecondNumber);
                }
                else if(Operator == "-")
                {
                    ShowCalculationResult(FirstNumber, SecondNumber, Operator, FirstNumber - SecondNumber);
                }
                else if(Operator == "*")
                {
                    ShowCalculationResult(FirstNumber, SecondNumber, Operator, FirstNumber * SecondNumber);
                }
                else if(Operator == "/")
                {
                    if(SecondNumber == 0)
                    {
                        Console.WriteLine("a number can not be devided by 0. enter a none zero character next time.");
                    }
                    else
                    {
                        ShowCalculationResult(FirstNumber, SecondNumber, Operator, FirstNumber / SecondNumber);
                    }
                }
                else
                {
                    Console.WriteLine("your third entry is not an operator.");
                }
            }
        }
    }
}