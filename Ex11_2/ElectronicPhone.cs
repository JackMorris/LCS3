using System;

namespace Ex11_2
{
    class ElectronicPhone : Telephone
    {
        public override void Ring()
        {
            Console.WriteLine("Ringing the electronic phone");
        }
    }
}
