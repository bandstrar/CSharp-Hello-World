using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            var name = Console.ReadLine();

            if (args.Length != 0)
            {
                if (args[0] == "English")
                {
                    Console.WriteLine($"Hello {name}!");
                }
                else if (args[0] == "Latin")
                {
                    Console.WriteLine($"Salve {name}!");
                }
                else if (args[0] == "French")
                {
                    Console.WriteLine($"Bonjour {name}!");
                }
                else if (args[0] == "Uther")
                {
                    Console.WriteLine($"Well met {name}!");
                }
            }
            else
            {
                Console.WriteLine($"Howdy {name}!");
            }

            Console.WriteLine("What is your favorite color?");
            var color = Console.ReadLine();

            Random rnd = new Random();

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            var animalIndex = rnd.Next(animals.Length);

            Console.WriteLine($"Would you like to have a {color} {animals[animalIndex]}?");
        }
    }
}
