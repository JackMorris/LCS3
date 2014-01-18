using System;

namespace Ex7_4
{
    public class Square
    {
        // Points of square. P1 = bottom left, subsequent points labelled clockwise.
        private Point p1;
        private Point p2;
        private Point p3;
        private Point p4;

        public Square(Point bottomLeft, int sideLength)
        {
            p1 = new Point(bottomLeft.x, bottomLeft.y);
            p2 = new Point(bottomLeft.x, bottomLeft.y + sideLength);
            p3 = new Point(bottomLeft.x + sideLength, bottomLeft.y + sideLength);
            p4 = new Point(bottomLeft.x + sideLength, bottomLeft.y);
        }

        public void Draw()
        {
            // Output point coordinates
            Console.WriteLine("p1: {0}, p2: {1}, p3: {2}, p4: {3}\n",
                p1.CoordinateString(), p2.CoordinateString(), p3.CoordinateString(), p4.CoordinateString());

            // (Felt like actually drawing the square)
            int xl = p1.x;
            int xr = p3.x;
            int yt = p3.y;
            int yb = p1.y;

            for (int y = yt + 1; y >= 0; y--)
            {
                for (int x = 0; x <= xr + 1; x++)
                {
                    if (((x == xl || x == xr) && y >= yb && y <= yt)        // Point on vertical edge
                        || ((y == yt || y == yb) && x >= xl && x <= xr))    // Point on horizontal edge
                        Console.Write("+");
                    else if (x == 0 && y != 0)  // On Y-axis (exclude origin)
                        Console.Write("|");
                    else if (x != 0 && y == 0)  // On X-axis (exclude origin)
                        Console.Write("-");
                    else
                        Console.Write(" ");     // Empty Space
                }
                Console.Write("\n");
            }
        }
    }
}