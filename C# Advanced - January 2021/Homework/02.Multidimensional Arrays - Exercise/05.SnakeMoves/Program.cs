using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            int n = input[0];
            int m = input[1];
            char[,] matrix = new char[n, m];
            string currentWord = text;
            char currentChar = '\0';

            for (int row = 0; row < n; row++)
            {
                int backCol = matrix.GetLength(1) - 1;
                for (int col = 0; col < m; col++)
                {
                    currentChar = currentWord[0];
                    currentWord = currentWord.Remove(0, 1);
                    if (row % 2 == 0)
                    {
                        matrix[row, col] = currentChar;
                    }
                    else
                    {
                        matrix[row, backCol] = currentChar;
                        backCol--;
                    }
                    if (currentWord.Length == 0)
                    {
                        currentWord = text;
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
