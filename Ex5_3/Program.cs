using System;

namespace Ex5_3
{
    class Program
    {
        enum InputType
        {
            Zero,
            Odd,
            Even,
            MultipleOf10,
            TooLarge,
        }

        static void Main(string[] args)
        {
            // Get integer input.
            Console.Write("Enter value: ");
            var inputInt = Convert.ToInt32(Console.ReadLine());

            var inputType = InputType.TooLarge;
            if (inputInt < 100)
            {
                if (inputInt == 0)
                {
                    inputType = InputType.Zero;
                }
                else if (inputInt % 10 == 0)
                {
                    inputType = InputType.MultipleOf10;
                }
                else if (inputInt % 2 == 0)
                {
                    inputType = InputType.Even;
                }
                else
                {
                    inputType = InputType.Odd;
                }
            }

            switch (inputType)
            {
                case InputType.Zero:
                    Console.WriteLine("Input is 0");
                    break;
                case InputType.Odd:
                    Console.WriteLine("Input is odd");
                    break;
                case InputType.Even:
                    Console.WriteLine("Input is even");
                    break;
                case InputType.MultipleOf10:
                    Console.WriteLine("Input is multiple of 10");
                    break;
                case InputType.TooLarge:
                    Console.WriteLine("Input too large (> 100)");
                    break;
            }
        }
    }
}