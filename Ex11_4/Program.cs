using System;

namespace Ex11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalPhone phone1 = new DigitalPhone();
            DigitalPhone phone2 = new DigitalCellPhone();

            phone1.VoiceMail();
            phone2.VoiceMail();
        }
    }
}
