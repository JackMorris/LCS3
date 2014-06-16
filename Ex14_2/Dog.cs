using System;

namespace Ex14_2
{
    class Dog : Animal
    {
        public Dog(uint weight, string name) : base(weight, name) { }

        public override void Speak()
        {
            Console.WriteLine("Dog is speaking");
        }

        public override void Move()
        {
            Console.WriteLine("Dog is moving");
        }

        public override string ToString()
        {
            return String.Format("This dog is called {0}. Weight is {1} pounds.", this.Name, this.Weight);
        }
    }
}
