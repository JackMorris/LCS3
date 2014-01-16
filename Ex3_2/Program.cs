using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3_2
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

            Console.WriteLine("myInt: {0}\nmyFloat: {1}\nmyDouble: {2}\nmyChar: {3}\nmyString: {4}\n",
                myInt, myFloat, myDouble, myChar, myString);

            myInt = 25;
            myFloat = 100.3f;
            myDouble = 98765.4321;
            myChar = 'M';
            myString = "A quick movement of the enemy will jeopardize six gun boats.";

            Console.WriteLine("myInt: {0}\nmyFloat: {1}\nmyDouble: {2}\nmyChar: {3}\nmyString: {4}\n",
                myInt, myFloat, myDouble, myChar, myString);
        }
    }
}
