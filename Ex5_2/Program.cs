using System;

namespace Ex5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get integer input.
            Console.Write("Enter value: ");
            var inputInt = Convert.ToInt32(Console.ReadLine());

            // Three cases: == 0, 0 < input <= 100 (test for even, odd, multiple of ten also), > 100 (too large).
            if (inputInt == 0)
            {
                Console.WriteLine("Input is 0");
            }
            else if (inputInt <= 100)
            {
                if (inputInt % 10 == 0)
                {
                    Console.WriteLine("Input is multiple of 10");
                }
                else if (inputInt % 2 == 0)
                {
                    Console.WriteLine("Input is even");
                }
                else
                {
                    Console.WriteLine("Input is odd");
                }
            }
            else
            {
                Console.WriteLine("Input too large (> 100)");
            }
        }
    }
}