using System;

namespace Ex3_4
{
    class Program
    {
        // Delcare the months enumeration.
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("June's location value is {0}", (int)Months.June);
        }
    }
}
