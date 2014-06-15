using System;

namespace Ex11_3
{
    class DigitalPhone : Telephone
    {
        public DigitalPhone()
        {
            phonetype = "digital phone";
        }

        public override void Ring()
        {
            Console.WriteLine("Ringing the {0}", phonetype);
        }
    }
}
