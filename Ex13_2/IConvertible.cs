using System;

namespace Ex13_2
{
    interface IConvertible
    {
        string ConvertToCSharp(string input);
        string ConvertToVB(string input);
    }
}
