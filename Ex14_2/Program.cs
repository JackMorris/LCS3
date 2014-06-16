using System;
using System.Collections.Generic;

namespace Ex14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfAnimals = 10;
            List<Animal> animals = new List<Animal>();

            Random r = new Random();
            for (int index = 0; index < NumberOfAnimals; index++)
            {
                var animalShouldBeCat = (r.Next(2) == 0);
                uint nextWeight = (uint)r.Next(10, 40);
                Animal nextAnimal = animalShouldBeCat ? (Animal)(new Cat(nextWeight, "John")) : (Animal)(new Dog(nextWeight, "Dave"));
                animals.Add(nextAnimal);
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("/// SORTING ANIMALS BY WEIGHT...");
            animals.Sort();

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
