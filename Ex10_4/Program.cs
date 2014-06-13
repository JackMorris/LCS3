using System;

namespace Ex10_4
{
    class Program
    {
        private const int BoardSize = 8;
        private static string[,] chessboard = new string[BoardSize, BoardSize];

        static void InitializeChessboard()
        {
            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    var isBlack = (row + col) % 2 == 0;
                    chessboard[row, col] = isBlack ? "black" : "white";
                }
            }
        }

        static void QueryUser()
        {
            Console.Write("ROW: ");
            var row = Convert.ToInt32(Console.ReadLine());
            Console.Write("COL: ");
            var col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(chessboard[row, col]);
        }

        static void Main(string[] args)
        {
            InitializeChessboard();
            while (true)
            {
                QueryUser();
            }
        }
    }
}
