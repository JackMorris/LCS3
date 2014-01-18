using System;

namespace Ex7_3
{
    class Program
    {
        public static void Main()
        {
            Book book1 = new Book("Programming in C# 3.0", "Jesse Liberty and Donald Xie", "9780596527433");
            Book book2 = new Book("C# 3.0 In a Nutshell", "Joseph Albahari and Ben Albahari", "9780596527570");
            Book book3 = new Book("C# 3.0 Cookbook", "Jay Hilyard and Stephen Teilhet", "9780596516109");

            book1.DisplayBook();
            book2.DisplayBook();
            book3.DisplayBook();
        }
    }
}