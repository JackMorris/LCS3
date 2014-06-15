using System;

namespace Ex13_3
{
    interface ICodeChecker : IConvertible
    {
        bool CodeCheckSyntax(string input, string language);
    }
}
