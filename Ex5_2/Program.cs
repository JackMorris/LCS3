using System;

namespace Ex5_2
{
    class Program
    {
        static void Main()
        {
            // Get integer input.
            Console.Write("Enter value: ");
            var input = Convert.ToInt32(Console.ReadLine());

            // Three cases: ==0, 0<input<=100 (test for even, odd, multiple of ten also), >100 (too large).
            if (input == 0)
                Console.WriteLine("Input is 0");
            else if (input <= 100)
            {
                if (input % 2 == 0)
                    Console.WriteLine("Input is even");
                else
                    Console.WriteLine("Input is odd");

                if (input % 10 == 0)
                    Console.WriteLine("Input is multiple of 10");
            }
            else
                Console.WriteLine("Input too large (> 100)");
        }
    }
}