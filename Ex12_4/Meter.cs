using System;

namespace Ex12_4
{
    class Meter
    {
        private double length;

        public Meter(double length)
        {
            this.length = length;
        }

        public override string ToString()
        {
            if (length == 1)
            {
                return "1 meter";
            }
            return String.Format("{0} meters", length);
        }

        public static implicit operator Foot(Meter m)
        {
            var lengthInFeet = m.length * 3.28;
            return new Foot(lengthInFeet);
        }
    }
}
