using System;

namespace Ex11_4
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

        public virtual void VoiceMail() 
        {
            Console.WriteLine("You have a message. Press Play to retrieve.");
        }
    }
}
