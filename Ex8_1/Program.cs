using System;

namespace Ex8_1
{
    class Program
    {
        static void Triple(ref int value)
        {
            value *= 3;
        }

        static void Triple(ref double value)
        {
            value *= 3;
        }

        static void Main(string[] args)
        {
            var myInt = 3;
            Console.WriteLine("Before\tmyInt = {0}", myInt);
            Triple(ref myInt);
            Console.WriteLine("After\tmyInt = {0}", myInt);

            var myDouble = 4.2;
            Console.WriteLine("Before\tmyDouble = {0}", myDouble);
            Triple(ref myDouble);
            Console.WriteLine("After\tmyDouble = {0}", myDouble);
        }
    }
}