using System;
using System.Linq;

namespace Ex15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new String[6];
            strings[0] = "Hello ";
            strings[1] = "World";
            strings[2] = @"Come visit us at http://www.LibertyAssociates.com";
            strings[3] = strings[0] + strings[1];
            strings[4] = "world";
            strings[5] = strings[2];

            for (int index = 0; index < strings.Length; index++)
            {
                var s = strings[index];
                Console.WriteLine("String {0}: {1}", index + 1, s);
                Console.WriteLine("Length: {0}", s.Length);
                Console.WriteLine("Third character: {0}", s[2]);
                Console.WriteLine("'H' appears? {0}", s.Contains('H'));

                var sameAsString2 = (String.Compare(s, strings[1]) == 0);
                var sameAsString2CaseIgnored = (String.Compare(s, strings[1], true) == 0);

                Console.WriteLine("Same as string2? {0}", sameAsString2);
                Console.WriteLine("Same as string2 (case ignored)? {0}", sameAsString2CaseIgnored);
                Console.WriteLine();
            }
        }
    }
}
