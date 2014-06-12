using System;

namespace Ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myInt = 42;
            var myFloat = 98.6f;
            var myDouble = 12345.6789;
            var myChar = 'Z';
            var myString = "The quick brown fox jumped over the lazy dogs.";

            Console.WriteLine("myInt: {0}\nmyFloat: {1}\nmyDouble: {2}\nmyChar: {3}\nmyString: {4}", 
                myInt, myFloat, myDouble, myChar, myString);
        }
    }
}
