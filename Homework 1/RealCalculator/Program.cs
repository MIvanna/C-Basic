namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Task 1

            Console.WriteLine("Real Calculator");

            Console.Write("Please enter the first number: ");
            string firstNum = Console.ReadLine();

            Console.Write("Please enter the second number: ");
            string secondNum = Console.ReadLine();

            bool firstNumParse = double.TryParse(firstNum, out double firstNumber);
            bool secondNumParse = double.TryParse(secondNum, out double secondNumber);

            if (!firstNumParse || !secondNumParse)
            {
                Console.WriteLine("Wrong input. Please enter a number!");
                return;
            }

            Console.Write("Please enter what operation to preform ( +, - , * , / ): ");
            string operation = Console.ReadLine();

            double result;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"The result is: {result}");
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"The result is: {result}");
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"The result is: {result}");
                    break;

                case "/":

                    result = firstNumber / secondNumber;

                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Can not divide by 0");
                        return;
                    }
                    Console.WriteLine($"The result is: {result}");
                    break;

                default:
                    Console.WriteLine("Please enter valid input!");
                    break;
            }
        }
    }
}