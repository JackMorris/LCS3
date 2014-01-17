using System;

namespace Ex4_3
{
    class Program
    {
        // Declare passenger enum
        enum Passengers
        {
            Abby = 135,
            Bob = 175,
            Charlie = 55,
            Dawn = 45,
        }

        static void Main()
        {
            // Ride constants.
            const int MaxWeight = 300;
            const int MinWeight = 100;

            // Abby and Bob
            int weightSum = (int)Passengers.Abby + (int)Passengers.Bob;
            Console.WriteLine("Abby and Bob can ride? {0}", (weightSum > MinWeight) && (weightSum <= MaxWeight));

            // Bob and Charlie
            weightSum = (int)Passengers.Bob + (int)Passengers.Charlie;
            Console.WriteLine("Bob and Charlie can ride? {0}", (weightSum > MinWeight) && (weightSum <= MaxWeight));

            // Charlie and Dawn
            weightSum = (int)Passengers.Charlie + (int)Passengers.Dawn;
            Console.WriteLine("Charlie and Dawn can ride? {0}", (weightSum > MinWeight) && (weightSum <= MaxWeight));
        }
    }
}