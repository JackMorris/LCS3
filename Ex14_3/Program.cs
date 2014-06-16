using System;
using System.Collections.Generic;

namespace Ex14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfAnimals = 10;
            Stack<Animal> animalStack = new Stack<Animal>();
            Queue<Animal> animalQueue = new Queue<Animal>();

            Console.WriteLine("/// ORDER OF ENTRY...");
            Random r = new Random();
            for (int index = 0; index < NumberOfAnimals; index++)
            {
                var animalShouldBeCat = (r.Next(2) == 0);
                uint nextWeight = (uint)r.Next(10, 40);
                Animal nextAnimal = animalShouldBeCat ? (Animal)(new Cat(nextWeight, "John")) : (Animal)(new Dog(nextWeight, "Dave"));
                animalStack.Push(nextAnimal);
                animalQueue.Enqueue(nextAnimal);
                Console.WriteLine(nextAnimal);
            }

            Console.WriteLine();
            Console.WriteLine("/// OUTPUT FROM STACK...");
            foreach (Animal animal in animalStack)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();
            Console.WriteLine("/// OUTPUT FROM QUEUE...");
            foreach (Animal animal in animalQueue)
            {
                Console.WriteLine(animal);
            }

        }
    }
}
