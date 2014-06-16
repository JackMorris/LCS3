﻿using System;

namespace Ex15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var quote = "We choose to go to the moon. We choose to go to the moon in this " +
                        "decade and do the other things, not because they are easy, but " +
                        "because they are hard, because that goal will serve to organize " +
                        "and measure the best of our energies and skills, because that " +
                        "challenge is one that we are willing to accept, one we are " +
                        "unwilling to postpone, and one which we intend to win, and the " +
                        "others, too.";

            var stringToCount = "the";
            var splitQuote = quote.Split(new string[] { stringToCount }, StringSplitOptions.None);
            var count = splitQuote.Length - 1;

            Console.WriteLine("Occurances of '{0}' in quote = {1}.", stringToCount, count);
        }
    }
}
