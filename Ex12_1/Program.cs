using System;

namespace Ex12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("Jack", 10);
            Invoice invoice2 = new Invoice("Jack", 20);
            Console.WriteLine(invoice1);
            Console.WriteLine(invoice2);
            Console.WriteLine(invoice1 + invoice2);

            Invoice invoice3 = new Invoice("Jim", 20);
            Console.WriteLine(invoice1 + invoice3);
        }
    }
}
