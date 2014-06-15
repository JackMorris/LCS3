using System;

namespace Ex13_1
{
    interface IConvertible
    {
        string ConvertToCSharp(string input);
        string ConvertToVB(string input);
    }
}
