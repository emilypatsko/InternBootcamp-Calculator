using NCalc;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            var op = GetOperator("Please enter the operator");
            var number1 = GetInputNumber("Please enter the first number");
            var number2 = GetInputNumber("Please enter the second number");
            var expression = new Expression($"{number1}{op}{number2}");
            Console.WriteLine($"{number1} {op} {number2} = {expression.Evaluate()}");
        }

        static double GetInputNumber(string inputMessage, string errorMessage = "You must enter a valid number, please try again.")
        {
            while (true)
            {
                try
                {
                    Console.Write($"{inputMessage}: ");
                    var input = Console.ReadLine();
                    return Double.Parse(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(errorMessage);
                }
            }
        }

        static string GetOperator(string inputMessage)
        {
            var operators = new[] {"+", "-", "*", "/"};
            while (true)
            {
                try
                {
                    Console.Write($"{inputMessage}: ");
                    var input = Console.ReadLine()!.Trim();
                    if (!operators.Contains(input)) throw new Exception();
                    return input;
                }
                catch (Exception e)
                {
                    Console.WriteLine("You must enter one of +, -, *, /. Please try again.");
                }
            }
        }
    }
}