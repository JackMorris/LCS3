using System;

namespace Ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 42;
            float myFloat = 98.6f;
            double myDouble = 12345.6789;
            char myChar = 'Z';
            string myString = "The quick brown fox jumped over the lazy dogs.";

            Console.WriteLine("myInt: {0}\nmyFloat: {1}\nmyDouble: {2}\nmyChar: {3}\nmyString: {4}", 
                myInt, myFloat, myDouble, myChar, myString);
        }
    }
}
