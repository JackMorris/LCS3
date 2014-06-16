using System;

namespace Ex14_3
{
    class Cat : Animal
    {
        public Cat(uint weight, string name) : base(weight, name) { }

        public override void Speak()
        {
            Console.WriteLine("Cat is speaking");
        }

        public override void Move()
        {
            Console.WriteLine("Cat is moving");
        }

        public override string ToString()
        {
            return String.Format("This cat is called {0}. Weight is {1} pounds.", this.Name, this.Weight);
        }
    }
}
