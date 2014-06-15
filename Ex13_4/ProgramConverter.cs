using System;

namespace Ex13_4
{
    class ProgramConverter : IConvertible
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
