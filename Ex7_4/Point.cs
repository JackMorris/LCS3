using System;

namespace Ex7_4
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string CoordinateString()
        {
            return String.Format("({0}, {1})", x, y);
        }
    }
}