namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator!");
            var number1 = GetInputNumber("Please enter the first number");
            var number2 = GetInputNumber("Please enter the second number");
            Console.WriteLine($"{number1} x {number2} = {number1 * number2}");
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
    }
}