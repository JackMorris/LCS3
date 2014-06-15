using System;

namespace Ex13_4
{
    interface ICodeChecker : IConvertible
    {
        bool CodeCheckSyntax(string input, string language);
    }
}
