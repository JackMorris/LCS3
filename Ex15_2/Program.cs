using System;

namespace Ex15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var quote = "To be, or not to be: That is the question: Whether 'tis nobler in the mind to suffer the " +
                        "slings and arrows of outrageous fortune, or to take arms against a sea of troubles, and " +
                        "by opposing end them?";
            var words = quote.Split(' ');
            Array.Reverse(words);
            var reversedQuote = String.Join(" ", words);
            Console.WriteLine(reversedQuote);
        }
    }
}
