using System;

namespace Ex5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MaxCounterValue = 10;
            var counter = 1;

            // while()
            while (counter <= MaxCounterValue)
            {
                Console.WriteLine("{0}", counter);
                counter++;
            }

            // do..while()
            counter = 1;
            do
            {
                Console.WriteLine("{0}", counter);
                counter++;
            } while (counter <= MaxCounterValue);

            // for
            for (counter = 1; counter <= MaxCounterValue; counter++)
            {
                Console.WriteLine("{0}", counter);
            }
        }
    }
}