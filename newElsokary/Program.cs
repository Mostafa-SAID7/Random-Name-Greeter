using System;

namespace Elsokary
{
    public class Program
    {
        // Declare Random once to avoid same seed issue
        static Random rnd = new Random();

        public static void Main(string[] args)
        {
            Console.WriteLine("Random Greetings:\n");

            for (int i = 0; i < 5; i++) // Print 5 random greetings
            {
                string name = GetRandomName();
                Console.WriteLine("Hello " + name);
            }
        }

        public static string GetRandomName()
        {
            string[] names = { "Mostafa", "Ali", "Sara", "John", "Laila", "Ahmed", "Nora" };
            int index = rnd.Next(names.Length);
            return names[index];
        }
    }
}
