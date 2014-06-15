using System;

namespace Ex13_3
{
    class ProgramHelper : ICodeChecker
    {
        public string ConvertToCSharp(string input)
        {
            return String.Format("Converting {0} to C#...", input);
        }

        public string ConvertToVB(string input)
        {
            return String.Format("Converting {0} to VB...", input);
        }

        public bool CodeCheckSyntax(string input, string language)
        {
            return true;
        }
    }
}
