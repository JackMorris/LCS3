using System;

namespace Ex3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14159;
            Console.WriteLine("Pi: {0}", Pi);

            /*
            Pi = 3.1;   // Compilation error here, can't modify a const.
            Console.WriteLine("Pi: {0}", Pi);
            */
        }
    }
}
