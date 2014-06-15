using System;

namespace Ex13_2
{
    class ProgramHelper : IConvertible
    {
        public string ConvertToCSharp(string input)
        {
            return String.Format("Converting {0} to C#...", input);
        }

        public string ConvertToVB(string input)
        {
            return String.Format("Converting {0} to VB...", input);
        }
    }
}
