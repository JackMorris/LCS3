using System;

namespace Ex13_4
{
    class ProgramHelper : ProgramConverter, ICodeChecker
    {

        public bool CodeCheckSyntax(string input, string language)
        {
            return true;
        }
    }
}
