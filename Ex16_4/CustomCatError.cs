using System;

namespace Ex16_4
{
    class CustomCatError : ApplicationException
    {
        public CustomCatError(string message) : base(message) { }
    }
}
