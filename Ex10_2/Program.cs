using System;

namespace Ex10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var integers = new int[10];
            for (int i = 0; i < integers.Length; i++)
            {
                var userInput = Console.ReadLine();
                integers[i] = Convert.ToInt32(userInput);
            }

            Array.Sort(integers);
            Array.Reverse(integers);

            foreach (int integer in integers)
            {
                Console.WriteLine(integer);
            }
        }
    }
}
