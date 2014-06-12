using System;

namespace Ex7_3
{
    public class Book
    {
        private string title;
        private string author;
        private string publisher = "O'Reilly";
        private string isbn;

        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public void DisplayBook()
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", title, author, publisher, isbn);
        }
    }
}