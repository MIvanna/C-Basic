using System.Security.Cryptography.X509Certificates;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1  -Take one string from the input and print its last 5 characters.


            Console.WriteLine("Write something and the last 5 characters will be printed:");

            string firstInput = Console.ReadLine();

            string result = firstInput.Substring(firstInput.Length - 5);
            Console.WriteLine(result);


            //Task 2    -Take a sentence as input and print its words.

            Console.WriteLine("Write a sentence to print all the words separately:");

            string secondInput = Console.ReadLine();

            string[] split = secondInput.Split(' ');

            foreach (string s in split)
            {
                Console.WriteLine(s);
            }


            //Task 3

            Console.WriteLine("Insert a number to get the sum of its digits:");

            Console.WriteLine(SumOfNums(Console.ReadLine()));

            static int SumOfNums(string num)
            {
                int sum = 0;

                for (int i = 0; i < num.Length; i++)
                {
                    if (!int.TryParse(num[i].ToString(), out int currentNum))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                    else
                    {
                        sum += currentNum;

                    }
                }
                Console.WriteLine($"The sum is: {sum}");
                return sum;
            }


            //Bonus Take a sentence as an input and print its largest word.

            Console.WriteLine("Enter a sentence to see its largest word:");

            Console.WriteLine(LargestWord(Console.ReadLine()));


            static string LargestWord(string sentence)
            {
                string[] words = sentence.Split(' ', '.', ',');

                string largestWord = "";
                int largestIndex = 0;

                foreach (string word in words)
                {
                    if (word.Length > largestIndex)
                    {
                        largestIndex = word.Length;
                        largestWord = word;
                    }
                }
                Console.WriteLine($"The largest word in the sentence is: {largestWord}");

                return largestWord;
            }
        }
    }
}