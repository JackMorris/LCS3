using System;

namespace Ex4_1
{
    class Program
    {
        static void Main()
        {
            var x = 25;
            var y = 5;

            Console.WriteLine("Sum:\t\t{0}\nDifference\t{1}\nProduct\t\t{2}\nQuotient\t{3}\nModulus\t\t{4}", 
                x + y, x - y, x * y, x / y, x % y);
        }
    }
}