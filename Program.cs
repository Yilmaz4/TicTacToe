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
                            0, 0, 0
                        },
                        new List<int>()
                        {
                            0, 0, 0
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
                {2, "○"}
            };
            for (int i = 0; i < 3; i++)
            {
                if (i != 3) Console.WriteLine(i == 0 ? "┌───┬───┬───┐" : "├───┼───┼───┤");
                Console.WriteLine("│ " + marks[board.GetCell(i, 0)] + " │ " + marks[board.GetCell(i, 1)] + " │ " + marks[board.GetCell(i, 2)] + " │");
                if (i == 2) Console.WriteLine("└───┴───┴───┘");
            }
        }
        public static void Main(string[] args)
        {
            Board board = new Board();
            PrintBoard(board);
        }
    }
}