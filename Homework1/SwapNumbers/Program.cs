namespace SwapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3

            Console.WriteLine("Swap Numbers");

            Console.Write("Input the First Number: ");
            string firstNum = Console.ReadLine();

            Console.Write("Input the Second Number: ");
            string secondNum = Console.ReadLine();

            bool firstNumParse = int.TryParse(firstNum, out int firstNumber);
            bool secondNumParse = int.TryParse(secondNum, out int secondNumber);

            if (!firstNumParse || !secondNumParse)
            {
                Console.WriteLine("Error occured. Invalid input.");
            }
            else
            {
                Console.WriteLine("After Swapping: ");
                Console.WriteLine($"First Number: {secondNumber}");
                Console.WriteLine($"Second Number: {firstNumber}");
            }
        }
    }
}