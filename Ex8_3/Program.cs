using System;

namespace Ex8_3
{
    class Program
    {
        static void DoubleAndTriple(int value, ref int doubleValue, ref int tripleValue)
        {
            doubleValue = value * 2;
            tripleValue = value * 3;
        }

        static void Main(string[] args)
        {
            var value = 4;
            int doubleValue = 0;
            int tripleValue = 0;
            DoubleAndTriple(value, ref doubleValue, ref tripleValue);
            Console.WriteLine("Value: {0}, Double: {1}, Triple: {2}", value, doubleValue, tripleValue);
        }
    }
}
