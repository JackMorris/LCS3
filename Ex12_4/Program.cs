using System;

namespace Ex12_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Foot foot1 = new Foot(10);
            Meter meter1 = foot1;
            Console.WriteLine("{0} == {1}", foot1, meter1);

            Meter meter2 = new Meter(5);
            Foot foot2 = meter2;
            Console.WriteLine("{0} == {1}", meter2, foot2);
        }
    }
}
