using System;

namespace Ex7_3
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher = "O'Reilly";
        private string ISBN;

        public Book(string title, string author, string ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }

        public void DisplayBook()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", this.title, this.author, this.publisher, this.ISBN);
        }
    }
}