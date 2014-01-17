// I decided to take this question literally, and I didn't want to write 100 case statements, so I
// was a bit creative...

using System;

namespace Ex5_3
{
    class Program
    {
        enum ValueRange
        {
            Zero,
            LessThanHundred,
            GreaterThanHundred,
        }

        static void Main()
        {
            Console.Write("Enter value: ");
            int input = Convert.ToInt32(Console.ReadLine());

            bool isEven = (input % 2 == 0);
            bool multipleOfTen = (input % 10 == 0);
            ValueRange range = (input == 0) ? ValueRange.Zero : ((input <= 100) ? ValueRange.LessThanHundred : ValueRange.GreaterThanHundred);

            switch (range)
            {
                case ValueRange.Zero:
                    Console.WriteLine("Input is 0");
                    break;
                case ValueRange.LessThanHundred:
                    switch (isEven)
                    {
                        case true:
                            Console.WriteLine("Input is even");
                            break;
                        case false:
                            Console.WriteLine("Input is odd");
                            break;
                    }
                    switch (multipleOfTen)
                    {
                        case true:
                            Console.WriteLine("Input is multiple of 10");
                            break;
                    }
                    break;
                case ValueRange.GreaterThanHundred:
                    Console.WriteLine("Input too large (> 100)");
                    break;
            }
        }
    }
}