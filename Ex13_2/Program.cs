using System;

namespace Ex13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IConvertible helper = new ProgramHelper();
            Console.WriteLine(helper.ConvertToCSharp("C# code"));
            Console.WriteLine(helper.ConvertToVB("VB code"));
        }
    }
}
