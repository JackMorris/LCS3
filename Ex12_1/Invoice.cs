using System;

namespace Ex12_1
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
    }
}
