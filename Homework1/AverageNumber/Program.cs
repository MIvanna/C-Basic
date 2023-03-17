namespace AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int average;

            Console.Write("Enter the First number: ");
            string first = Console.ReadLine();
            bool firstParse = int.TryParse(first, out int firstNum);

            Console.Write("Enter the Second number: ");
            string second = Console.ReadLine();
            bool secondParse = int.TryParse(second, out int secondNum);

            Console.Write("Enter the Third number: ");
            string third = Console.ReadLine();
            bool thirdParse = int.TryParse(third, out int thirdNum);

            Console.Write("Enter the Fourth number: ");
            string fourth = Console.ReadLine();
            bool fourthParse = int.TryParse(fourth, out int fourthNum);

            if (!firstParse || !secondParse || !thirdParse || !fourthParse)
            {
                Console.WriteLine("Error occured!");
                return;
            }
            else
            {
                int average = (firstNum + secondNum + thirdNum + fourthNum) / 4;

                Console.WriteLine($"The average of {firstNum}, {secondNum}, {thirdNum} and {fourthNum} is: {average}");

            }
        }
    }
}