namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Console.WriteLine("Please enter your name:");
            human1.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            human1.LastName = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid input. Please enter correct age.");
            }
            else
            {
                human1.Age = age;
            }

            Console.WriteLine(human1.GetPersonStats());

        }
    }
}