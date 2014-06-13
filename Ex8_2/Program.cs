using System;

namespace Ex8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            Console.WriteLine("Dog color = {0}", dog.Color);

            var newWeight = Convert.ToInt32(Console.ReadLine());
            dog.Weight = newWeight;
            Console.WriteLine("Dog weight = {0}", dog.Weight);
        }
    }
}
