namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum Of Even");

            int[] numbers = new int[7];
            int result = 0;

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine($"Enter integer no. {i}:");
                //  string input = Console.ReadLine();
                //  bool numParsed = int.TryParse(input, out numbers[i]);

                if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Error occured!");
                    return;
                }
            }

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
            }

            Console.WriteLine($"The result is: {result}");
        }
    }
}