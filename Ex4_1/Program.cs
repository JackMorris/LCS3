using System;

namespace Ex4_1
{
    class Program
    {
        static void Main()
        {
            int x = 25;
            int y = 5;

            Console.WriteLine("Sum:\t\t{0}\nDifference\t{1}\nProduct\t\t{2}\nQuotient\t{3}\nModulus\t\t{4}", 
                x + y, x - y, x * y, x / y, x % y);
        }
    }
}