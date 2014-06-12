using System;

namespace Ex4_3
{
    class Program
    {
        enum PassengerWeight
        {
            Abby = 135,
            Bob = 175,
            Charlie = 55,
            Dawn = 45,
        }

        static void Main(string[] args)
        {
            PrintWeightCheck(PassengerWeight.Abby, PassengerWeight.Bob);
            PrintWeightCheck(PassengerWeight.Bob, PassengerWeight.Charlie);
            PrintWeightCheck(PassengerWeight.Charlie, PassengerWeight.Dawn);
        }

        static void PrintWeightCheck(PassengerWeight passenger1Weight, PassengerWeight passenger2Weight)
        {
            const int MaxWeight = 300;
            const int MinWeight = 100;

            var totalWeight = (int)passenger1Weight + (int)passenger2Weight;
            var canRide = (totalWeight > MinWeight) && (totalWeight < MaxWeight);

            Console.WriteLine("{0} and {1} can ride? {2}", passenger1Weight, passenger2Weight, canRide);
        }
    }
}