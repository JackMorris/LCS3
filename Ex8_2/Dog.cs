using System;

namespace Ex8_2
{
    class Dog
    {
        private int weight;
        private string color = "Brown";

        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = Color;
            }
        }
    }
}
