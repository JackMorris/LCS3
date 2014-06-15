using System;

namespace Ex11_1
{
    class Telephone
    {
        protected string phonetype;

        public void Ring()
        {
            Console.WriteLine("Ringing the {0}.", phonetype);
        }
    }
}
