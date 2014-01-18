using System;

namespace Ex7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point bottomLeft = new Point(0, 2);
            Square mySquare = new Square(bottomLeft, 4);
            mySquare.Draw();
        }
    }
}
