using System;

namespace Ex14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfAnimals = 10;
            Animal[] animals = new Animal[NumberOfAnimals];

            Random r = new Random();
            for (int index = 0; index < NumberOfAnimals; index++)
            {
                var animalShouldBeCat = (r.Next(2) == 0);
                Animal nextAnimal = animalShouldBeCat ? (Animal)(new Cat(10, "John")) : (Animal)(new Dog(20, "Dave"));
                animals[index] = nextAnimal;
            }

            foreach (Animal animal in animals)
            {
                animal.Speak();
                animal.Move();
                Console.WriteLine(animal);
            }
        }
    }
}
