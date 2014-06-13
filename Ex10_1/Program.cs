using System;

namespace Ex10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new Dog[3];

            dogs[0] = new Dog();
            dogs[0].Name = "Milo";
            dogs[0].Weight = 26;

            dogs[1] = new Dog();
            dogs[1].Name = "Frisky";
            dogs[1].Weight = 10;

            dogs[2] = new Dog();
            dogs[2].Name = "Laika";
            dogs[2].Weight = 50;

            foreach (Dog dog in dogs)
            {
                Console.WriteLine("Name: {0}\tWeight: {1} pounds", dog.Name, dog.Weight);
            }
        }
    }
}
