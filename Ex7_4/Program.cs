using System;

namespace Ex7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var bottomLeft = new Point(0, 2);
            var mySquare = new Square(bottomLeft, 4);
            mySquare.Draw();
        }
    }
}
