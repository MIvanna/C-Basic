namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            string[] studentsG2 = { "Zdravka", "Petkana", "Stanka", "Branka", "Trajana" };

            Console.WriteLine("Enter student group: (there are 1 and 2)");

            if (!int.TryParse(Console.ReadLine(), out int decision))
            {
                Console.WriteLine("Error occured! Please enter 1 or 2:");
            }
            else if (decision == 1)
            {
                Console.WriteLine("The Students in G1 are:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine($"{student}");
                }
            }
            else if (decision == 2)
            {
                Console.WriteLine("The Students in G2 are:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine($"{student}");
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}