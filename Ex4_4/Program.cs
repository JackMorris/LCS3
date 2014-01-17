using System;

namespace Ex4_4
{
    class Program
    {
        static void Main()
        {
            const float Pi = 3.14159f;
            const int Radius = 5;

            // Surface area (4*Pi*R^2).
            float surfaceArea = 4 * Pi * Radius * Radius;
            Console.WriteLine("Surface area: {0}", surfaceArea);

            // Volume ((4/3)*Pi*R^3).
            float volume = (4f / 3f) * Pi * Radius * Radius * Radius;
            Console.WriteLine("Volume: {0}", volume);

            // Output maximum measurement.
            string maxMeasurmentName = (surfaceArea > volume) ? "Surface area" : "Volume";
            Console.WriteLine("{0} is the largest measurement", maxMeasurmentName);
        }
    }
}