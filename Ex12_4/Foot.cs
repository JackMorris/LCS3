using System;

namespace Ex12_4
{
    class Foot
    {
        private double length;

        public Foot(double length)
        {
            this.length = length;
        }

        public override string ToString()
        {
            if (length == 1)
            {
                return "1 foot";
            }
            return String.Format("{0} feet", length);
        }

        public static implicit operator Meter(Foot f)
        {
            double lengthInMeters = f.length * 0.3048;
            return new Meter(lengthInMeters);
        }
    }
}
