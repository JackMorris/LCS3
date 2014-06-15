using System;

namespace Ex11_4
{
    class DigitalCellPhone : DigitalPhone
    {
        public override void VoiceMail()
        {
            Console.WriteLine("You have a message. Call to retrieve.");
        }
    }
}
