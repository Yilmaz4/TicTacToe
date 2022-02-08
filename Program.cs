namespace TicTacToe
{
    class Program
    {
        public class Board
        {
            private List<List<int>> board = new()
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
        private static void RenderBoard(Board board)
        {
            Dictionary<int, string> marks = new()
            {
                {0, " "},
                {1, "x"},
                {2, "o"}
            };
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (i != 3)
                {
                    Console.WriteLine(i == 0 ? "┌───┬───┬───┐" : "├───┼───┼───┤");
                } 
                Console.ResetColor();
                for (int j = 0; j < 3; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("│ ");
                    Console.ResetColor();
                    Console.Write(marks[board.GetCell(i, j)]);
                    Console.ForegroundColor= ConsoleColor.DarkGray;
                    Console.Write((j == 2 ? " │\n" : " "));
                }
                Console.ForegroundColor= ConsoleColor.DarkGray;
                if (i == 2) Console.WriteLine("└───┴───┴───┘");
                Console.ResetColor();
            }
        }
        private static void DecideMove(Board board)
        {

        }
        public static void Main(string[] args)
        {
            Board board = new();
            RenderBoard(board);
            Console.Write("\nWelcome to TicTacToe! Who should start first? ");
            string? input = Console.ReadLine();
            List<string> inputs = new() {"Computer", "Me"};
            if (inputs.OrderBy(s => string.Compare(s, input)).First() == "You")
            {

            }
        }
    }
}
