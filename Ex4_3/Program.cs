using System;

namespace Ex4_3
{
    class Program
    {
        // Declare passenger enum
        enum Passenger
        {
            Abby = 135,
            Bob = 175,
            Charlie = 55,
            Dawn = 45,
        }

        static void Main()
        {
            PrintWeightCheck(Passenger.Abby, Passenger.Bob);
            PrintWeightCheck(Passenger.Bob, Passenger.Charlie);
            PrintWeightCheck(Passenger.Charlie, Passenger.Dawn);
        }

        static void PrintWeightCheck(Passenger p1, Passenger p2)
        {
            // Ride constants.
            const int MaxWeight = 300;
            const int MinWeight = 100;

            var weightSum = (int)p1 + (int)p2;
            var canRide = (weightSum > MinWeight) && (weightSum < MaxWeight);

            Console.WriteLine("{0} and {1} can ride? {2}", p1, p2, canRide);
        }
    }
}