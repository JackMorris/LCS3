using System;

namespace Ex7_4
{
    public class Square
    {
        private Point topLeft;
        private Point topRight;
        private Point bottomLeft;
        private Point bottomRight;

        public Square(Point bottomLeft, int sideLength)
        {
            this.topLeft = new Point(bottomLeft.x, bottomLeft.y + sideLength);
            this.topRight = new Point(bottomLeft.x + sideLength, bottomLeft.y + sideLength);
            this.bottomLeft = new Point(bottomLeft.x, bottomLeft.y);
            this.bottomRight = new Point(bottomLeft.x + sideLength, bottomLeft.y);
        }

        public void PrintDescription()
        {
            Console.WriteLine("Top left:\t{0}", topLeft.CoordinateString());
            Console.WriteLine("Top right:\t{0}", topRight.CoordinateString());
            Console.WriteLine("Bottom left:\t{0}", bottomLeft.CoordinateString());
            Console.WriteLine("Bottom right:\t{0}", bottomRight.CoordinateString());
        }

        public void Draw()
        {
            var squareBoundary = new {  xLeft = (int)bottomLeft.x, 
                                        xRight = (int)bottomRight.x, 
                                        yTop = (int)topLeft.y, 
                                        yBottom = (int)bottomLeft.y };

            var drawBoundary = new {    xLeft = 0, 
                                        xRight = squareBoundary.xRight + 1, // Provide a margin
                                        yTop = squareBoundary.yTop + 1,     // by adding 1.
                                        yBottom = 0 };
            
            for (int y = drawBoundary.yTop; y >= drawBoundary.yBottom; y--)
            {
                for (int x = drawBoundary.xLeft; x <= drawBoundary.xRight; x++)
                {
                    var onVerticalEdge = (x == squareBoundary.xLeft || x == squareBoundary.xRight) && y >= squareBoundary.yBottom && y <= squareBoundary.yTop;
                    var onHorizontalEdge = (y == squareBoundary.yBottom || y == squareBoundary.yTop) && x >= squareBoundary.xLeft && x <= squareBoundary.xRight;
                    var onYAxis = (x == drawBoundary.xLeft);
                    var onXAxis = (y == drawBoundary.yBottom);
                    var onOrigin = onXAxis && onYAxis;
                    
                    if (onVerticalEdge || onHorizontalEdge)
                    {
                        Console.Write("#");
                    }
                    else if (onOrigin)
                    {
                        Console.Write("+");
                    }
                    else if (onYAxis)
                    {
                        Console.Write("|");
                    }
                    else if (onXAxis)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        // Empty space.
                        Console.Write(" ");
                    }
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}