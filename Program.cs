namespace TicTacToe
{
    class Program
    {
        public class Board
        {
            private List<List<int>> board = new List<List<int>>()
                    {
                        new List<int>()
                        {
                            1, 0, 2
                        },
                        new List<int>()
                        {
                            0, 2, 1
                        },
                        new List<int>()
                        {
                            0, 0, 0
                        }
                    };
            public int GetCell(int x, int y)
            {
                return board[x][y];
            }
            public void SetCell(int x, int y, int val)
            {
                board[x][y] = val;
            }
        }
        static void PrintBoard(Board board)
        {
            var marks = new Dictionary<int, string>()
            {
                {0, " "},
                {1, "x"},
                {2, "o"}
            };
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (i != 3) Console.WriteLine(i == 0 ? "┌───┬───┬───┐" : "├───┼───┼───┤");
                for (int j = 0; j < 3; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ "); Console.ResetColor(); Console.Write(marks[board.GetCell(i, 0)]);
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ "); Console.ResetColor(); Console.Write(marks[board.GetCell(i, 1)]);
                    Console.Write(" │ ");
                    Console.ForegroundColor = ConsoleColor.DarkGray; Console.Write("│ "); Console.ResetColor();
                    Console.Write(" │ "); Console.Write(marks[board.GetCell(i, 2)] + " │");
                }
            
                if (i == 2) Console.WriteLine("└───┴───┴───┘");
                Console.ResetColor();
            }
        }
        public static void Main(string[] args)
        {
            Board board = new Board();
            PrintBoard(board);
        }
    }
}
