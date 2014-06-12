using System;

namespace Ex5_1
{
    class Program
    {
        static void Main()
        {
            // while()
            var i = 1;
            while (i <= 10)
            {
                Console.WriteLine("{0}", i);
                i++;
            }

            // do..while()
            i = 1;
            do
            {
                Console.WriteLine("{0}", i);
                i++;
            } while (i <= 10);

            // for
            for (i = 1; i <= 10; i++)
                Console.WriteLine("{0}", i);
        }
    }
}