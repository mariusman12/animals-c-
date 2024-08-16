using System;



namespace OopHelloWorld
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Animal[] animals = {
                new Cat(),
                new Dog(),
                new Frog()
            };

            foreach (Animal animal in animals)
            {
                string animalName = animal.Name;
                string sound = animal.MakeSound();

                Console.WriteLine($"The {animalName} makes '{sound}'.");
            }

            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine();
        }
    }
}
