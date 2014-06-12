using System;

namespace Ex7_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("4.2 + 8.1 = {0}", Math.Add(4.2, 8.1));
            Console.WriteLine("1.1 - 0.6 = {0}", Math.Subtract(1.1, 0.6));
            Console.WriteLine("8.3 * 2.7 = {0}", Math.Multiply(8.3, 2.7));
            Console.WriteLine("9.3 / 3.0 = {0}", Math.Divide(9.3, 3.0));
        }
    }
}