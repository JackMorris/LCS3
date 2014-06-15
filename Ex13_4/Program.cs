using System;

namespace Ex13_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramConverter[] converters = new ProgramConverter[10];
            for (int i = 0; i < converters.Length; i++)
            {
                if (i % 2 == 0)
                {
                    converters[i] = new ProgramConverter();
                }
                else
                {
                    converters[i] = new ProgramHelper();
                }
            }

            foreach (ProgramConverter converter in converters)
            {
                Console.WriteLine(converter.ConvertToCSharp("Some C# code"));
                Console.WriteLine(converter.ConvertToVB("Some VB code"));

                ProgramHelper helper = converter as ProgramHelper;
                if (helper != null)
                {
                    Console.WriteLine(helper.CodeCheckSyntax("code", "C#"));
                }
            }

        }
    }
}
