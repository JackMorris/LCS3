using System;

namespace Ex12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("Jack", 10);
            Invoice invoice2 = new Invoice("Jack", 5);
            Console.WriteLine("'{0}' < '{1}'? {2}", invoice1, invoice2, invoice1 < invoice2);
            Console.WriteLine("'{0}' <= '{1}'? {2}", invoice1, invoice2, invoice1 <= invoice2);
            Console.WriteLine("'{0}' > '{1}'? {2}", invoice1, invoice2, invoice1 > invoice2);
            Console.WriteLine("'{0}' >= '{1}'? {2}", invoice1, invoice2, invoice1 >= invoice2);


            Invoice invoice3 = new Invoice("Jim", 20);
            Console.WriteLine("'{0}' < '{1}'? {2}", invoice1, invoice3, invoice1 < invoice3);
            Console.WriteLine("'{0}' <= '{1}'? {2}", invoice1, invoice3, invoice1 <= invoice3);
            Console.WriteLine("'{0}' > '{1}'? {2}", invoice1, invoice3, invoice1 > invoice3);
            Console.WriteLine("'{0}' >= '{1}'? {2}", invoice1, invoice3, invoice1 >= invoice3);
        }
    }
}
