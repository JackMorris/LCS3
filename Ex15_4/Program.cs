using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Ex15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var quote = "We hold these truths to be self-evident, that all men are created " +
                        "equal, that they are endowed by their Creator with certain " +
                        "unalienable Rights, that among these are Life, Liberty and " +
                        "the pursuit of Happiness.";

            var regex = new Regex(" |, |,");
            var words = regex.Split(quote);

            var stringBuilder = new StringBuilder();
            var numberOfWords = words.Length;
            for (var index = 0; index < numberOfWords; index++)
            {
                stringBuilder.AppendFormat("{0}:\t{1}{2}", index + 1, words[index], Environment.NewLine);
            }
            Console.WriteLine(stringBuilder);
        }
    }
}
