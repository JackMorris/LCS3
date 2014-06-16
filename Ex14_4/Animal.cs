using System;

namespace Ex14_4
{
    abstract class Animal : IComparable<Animal>
    {
        public uint Weight { get; set; }
        public string Name { get; set; }

        public Animal(uint weight, string name)
        {
            this.Weight = weight;
            this.Name = name;
        }

        public abstract void Speak();
        public abstract void Move();

        public int CompareTo(Animal animal)
        {
            return this.Weight.CompareTo(animal.Weight);
        }

        public int CompareTo(Animal animal, AnimalComparisonType comparisonType)
        {
            switch (comparisonType)
            {
                case AnimalComparisonType.Name:
                    return this.Name.CompareTo(animal.Name);
                case AnimalComparisonType.Weight:
                    return this.Weight.CompareTo(animal.Weight);
                default:
                    return 0;
            }
        }
    }
}
