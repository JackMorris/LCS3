using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex14_4
{
    enum AnimalComparisonType
    {
        Name,
        Weight
    }
    
    class AnimalComparator : IComparer<Animal>
    {
        private AnimalComparisonType comparisonType;

        public AnimalComparator(AnimalComparisonType comparisonType)
        {
            this.comparisonType = comparisonType;
        }

        public int Compare(Animal lhs, Animal rhs)
        {
            return lhs.CompareTo(rhs, this.comparisonType);
        }
    }
}
