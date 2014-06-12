using System;

namespace Ex5_4
{
    class Program
    {
        static void Main()
        {
            var i = 0;
            var j = 25;
            for (; i <= j; i++, j--)
            {
                Console.WriteLine("i: {0}\tj: {1}", i, j);
            }
            Console.WriteLine("Crossed over!");
        }
    }
}