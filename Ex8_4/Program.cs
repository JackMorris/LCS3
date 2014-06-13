using System;

namespace Ex8_4
{
    class Program
    {
        static void DoubleAndTriple(int value, out int doubleValue, out int tripleValue)
        {
            doubleValue = value * 2;
            tripleValue = value * 3;
        }

        static void Main(string[] args)
        {
            var value = 4;
            int doubleValue;
            int tripleValue;
            DoubleAndTriple(value, out doubleValue, out tripleValue);
            Console.WriteLine("Value: {0}, Double: {1}, Triple: {2}", value, doubleValue, tripleValue);
        }
    }
}
