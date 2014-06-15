using System;

namespace Ex13_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICodeChecker checker = new ProgramHelper();
            Console.WriteLine(checker.ConvertToCSharp("C# code"));
            Console.WriteLine(checker.ConvertToVB("VB code"));
            Console.WriteLine("Code is valid? {0}", checker.CodeCheckSyntax("Some code", "C#"));
        }
    }
}
