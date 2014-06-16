using System;

namespace Ex14_2
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
    }
}
