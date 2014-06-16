using System;

namespace Ex16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfIntegers = 100;
            var integers = new int[NumberOfIntegers];
            var random = new Random();
            for (var index = 0; index < NumberOfIntegers; index++)
            {
                integers[index] = random.Next(1000);
            }

            var shouldAskUser = true;
            while (shouldAskUser)
            {
                try
                {
                    Console.Write("Which integer to view? (1-{0}): ", NumberOfIntegers);
                    var choiceIndex = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Integer #{0}: {1}", choiceIndex, integers[choiceIndex - 1]);
                }
                catch
                {
                    Console.WriteLine("Invalid index specified");
                }
                finally
                {
                    Console.Write("Choose again? (y/n): ");
                    shouldAskUser = (Console.ReadLine() == "y");
                    Console.WriteLine();
                }
            }

        }
    }
}
