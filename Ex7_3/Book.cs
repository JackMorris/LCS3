using System;

namespace Ex7_3
{
    public class Book
    {
        private String title;
        private String author;
        private String publisher = "O'Reilly";
        private String ISBN;

        public Book(String title, String author, String ISBN)
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