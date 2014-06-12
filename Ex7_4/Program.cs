using System;

namespace Ex7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var bottomLeftPoint = new Point(0, 3);
            var square = new Square(bottomLeftPoint, 4);
            square.PrintDescription();
            square.Draw();
        }
    }
}
