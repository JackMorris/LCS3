﻿using System;

namespace Ex3_2
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

            Console.WriteLine("myInt:\t\t{0}", myInt);
            Console.WriteLine("myFloat:\t{0}", myFloat);
            Console.WriteLine("myDouble:\t{0}", myDouble);
            Console.WriteLine("myChar:\t\t{0}", myChar);
            Console.WriteLine("myString:\t{0}", myString);

            myInt = 25;
            myFloat = 100.3f;
            myDouble = 98765.4321;
            myChar = 'M';
            myString = "A quick movement of the enemy will jeopardize six gun boats.";

            Console.WriteLine("myInt:\t\t{0}", myInt);
            Console.WriteLine("myFloat:\t{0}", myFloat);
            Console.WriteLine("myDouble:\t{0}", myDouble);
            Console.WriteLine("myChar:\t\t{0}", myChar);
            Console.WriteLine("myString:\t{0}", myString);
        }
    }
}
