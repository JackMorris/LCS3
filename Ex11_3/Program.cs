using System;

namespace Ex11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Telephone phone1 = new DigitalPhone();
            Telephone phone2 = new TalkingPhone();

            phone1.Ring();
            phone2.Ring();
        }
    }
}
