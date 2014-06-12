using System;

namespace Ex7_1
{
    class Program
    {
        public static void Main()
        {
            var myMath = new Math();
            Console.WriteLine("4.2 + 8.1 = {0}", myMath.Add(4.2, 8.1));
            Console.WriteLine("1.1 - 0.6 = {0}", myMath.Subtract(1.1, 0.6));
            Console.WriteLine("8.3 * 2.7 = {0}", myMath.Multiply(8.3, 2.7));
            Console.WriteLine("9.3 / 3.0 = {0}", myMath.Divide(9.3, 3.0));
        }
    }
}