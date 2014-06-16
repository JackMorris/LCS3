using System;

namespace Ex14_1
{
    abstract class Animal
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
    }
}
