using System;

namespace Ex4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 25;
            var y = 5;
            
            Console.WriteLine("Sum:\t\t{0}", x + y);
            Console.WriteLine("Difference:\t{0}", x - y);
            Console.WriteLine("Product:\t{0}", x * y);
            Console.WriteLine("Quotient:\t{0}", x / y);
            Console.WriteLine("Modulus:\t{0}", x % y);
        }
    }
}