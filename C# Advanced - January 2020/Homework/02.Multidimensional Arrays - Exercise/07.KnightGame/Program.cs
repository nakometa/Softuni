using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];
            int removedKnights = 0;

            for (int row = 0; row < n; row++)
            {
                string rowData = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    board[row, col] = rowData[col];
                }
            }

            while (true)
            {
                int maxAttackedKnights = 0;
                int knightRow = -1;
                int knightCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (board[row,col] != 'K')
                        {
                            continue;
                        }
                        int count = GetCountOfAttackedKnights(board, row, col);

                        if (maxAttackedKnights < count)
                        {
                            knightRow = row;
                            knightCol = col;
                            maxAttackedKnights = count;
                        }
                    }
                }

                if (maxAttackedKnights == 0)
                {
                    break;
                }
                removedKnights++;
                board[knightRow, knightCol] = '0';
            }

            Console.WriteLine(removedKnights);
        }

        private static int GetCountOfAttackedKnights(char[,] board, int row, int col)
        {
            int count = 0;
            if (ContainsKnight(board, row + 1, col + 2))
            {
                count++;
            }
            if (ContainsKnight(board, row + 1, col - 2))
            {
                count++;
            }
            if (ContainsKnight(board, row + 2, col + 1))
            {
                count++;
            }
            if (ContainsKnight(board, row + 2, col - 1))
            {
                count++;
            }
            if (ContainsKnight(board, row - 1, col - 2))
            {
                count++;
            }
            if (ContainsKnight(board, row - 1, col + 2))
            {
                count++;
            }
            if (ContainsKnight(board, row  - 2, col - 1))
            {
                count++;
            }
            if (ContainsKnight(board, row - 2, col + 1))
            {
                count++;
            }
            return count;
        }

        private static bool ContainsKnight(char[,] board, int row, int col)
        {
            if (!isValid(board, row, col))
            {
                return false;
            }
            return board[row, col] == 'K';
        }

        private static bool isValid(char[,] board, int row, int col)
        {
            bool valid = row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(1);
            return valid;
        }
    }
}
