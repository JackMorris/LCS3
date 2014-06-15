using System;

namespace Ex11_3
{
    class TalkingPhone : Telephone
    {
        public TalkingPhone()
        {
            phonetype = "talking phone";
        }

        public override void Ring()
        {
            Console.WriteLine("This is the {0}", phonetype);
        }
    }
}
