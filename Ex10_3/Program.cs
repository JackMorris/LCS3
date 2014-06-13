using System;

namespace Ex10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfDogs = 3;
            var dogs = new Dog[NumberOfDogs];
            var dogAwards = new string[NumberOfDogs][];

            dogs[0] = new Dog();
            dogs[0].Name = "Milo";
            dogs[0].Weight = 26;
            dogAwards[0] = new string[] { "Best Dog", "Smallest Dog" };

            dogs[1] = new Dog();
            dogs[1].Name = "Frisky";
            dogs[1].Weight = 10;
            dogAwards[1] = new string[] { "Tallest Dog" };

            dogs[2] = new Dog();
            dogs[2].Name = "Laika";
            dogs[2].Weight = 50;
            dogAwards[2] = new string[] { "Best Coat", "Heaviest Dog", "Oldest Dog" };

            for (int dogIndex = 0; dogIndex < NumberOfDogs; dogIndex++)
            {
                Dog dog = dogs[dogIndex];
                Console.WriteLine("Name: {0}\tWeight: {1} pounds", dog.Name, dog.Weight);
                foreach (string award in dogAwards[dogIndex])
                {
                    Console.WriteLine(" - {0}", award);
                }
                Console.WriteLine();
            }
        }
    }
}
