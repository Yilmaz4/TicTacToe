using System;
using System.Collections.Generic;

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
            public List<List<int>> Raw()
            {
                return board;
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
        private static void DoMove(Board board)
        {
            List<bool> boardEmpty = new();
            foreach (List<int> subboard in board.Raw())
            {
                if (subboard.Any(o => o != subboard[0]) & Convert.ToBoolean(subboard[0])) boardEmpty.Add(true);
                else boardEmpty.Add(false);
            }
            if (boardEmpty.Count == 3 & boardEmpty.Any(o => o != boardEmpty[0]))
            {
                List<List<int>> moves = new()
                {
                    new List<int>()
                    {
                        0, 0
                    },
                    new List<int>()
                    {
                        0, 2
                    },
                    new List<int>()
                    {
                        2, 0
                    },
                    new List<int>()
                    {
                        2, 2
                    },
                };
                Random random = new();
                List<int> move = moves[random.Next(moves.Count)];
                board.SetCell(move[0], move[1], 1);
            }
        }
        public static int Compare(string s, string t)
        {
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];
            if (n == 0)
            {
                return m;
            }
            if (m == 0)
            {
                return n;
            }
            for (int i = 0; i <= n; d[i, 0] = i++)
                ;
            for (int j = 0; j <= m; d[0, j] = j++)
                ;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            return d[n, m];
        }
        public static void Main(string[] args)
        {
            Board board = new();
            RenderBoard(board);
            while (true)
            {
                Console.Write("\nWelcome to TicTacToe! Who should start first? ");
                string? input = Console.ReadLine();

                if (true) ;

                while (false)
                {
                    Console.WriteLine("You've entered an invalid input! It can be either \"Computer\" or \"Me\" which is you.\nPress any key to continue . . .");
                    Console.ReadKey();
                    continue;
                }
            }
        }
    }
}
