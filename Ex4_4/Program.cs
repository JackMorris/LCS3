using System;

namespace Ex4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const float Pi = 3.14159f;
            const int Radius = 5;

            // Surface area (4*Pi*R^2).
            var surfaceArea = 4 * Pi * Radius * Radius;
            Console.WriteLine("Surface area: {0}", surfaceArea);

            // Volume ((4/3)*Pi*R^3).
            var volume = (4f / 3f) * Pi * Radius * Radius * Radius;
            Console.WriteLine("Volume: {0}", volume);

            var maxMeasurementName = (surfaceArea > volume) ? "Surface area" : "Volume";
            Console.WriteLine("{0} is the largest measurement", maxMeasurementName);
        }
    }
}