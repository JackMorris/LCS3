using System;

namespace Ex12_2
{
    class Invoice
    {
        private string vendor;
        private double amount;

        public Invoice(string vendor, double amount)
        {
            this.vendor = vendor;
            this.amount = amount;
        }

        public override string ToString()
        {
            if (vendor == "")
            {
                return "BLANK";
            }
            return String.Format("{0}: £{1}", vendor, amount);
        }

        public static Invoice operator +(Invoice lhs, Invoice rhs)
        {
            if (lhs.vendor == rhs.vendor)
            {
                return new Invoice(lhs.vendor, lhs.amount + rhs.amount);
            }
            return new Invoice("", 0);
        }

        public static bool operator ==(Invoice lhs, Invoice rhs)
        {
            return (lhs.vendor == rhs.vendor) && (lhs.amount == rhs.amount);
        }

        public static bool operator !=(Invoice lhs, Invoice rhs)
        {
            return !(lhs == rhs);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Invoice))
            {
                return false;
            }
            return this == (Invoice)obj;
        }
    }
}
