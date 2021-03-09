using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            char[,] matrix = new char[n, m];
            int counter = 0;

            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0;  col < m - 1; col++)
                {
                    char firstChar = matrix[row, col];
                    char secondChar = matrix[row, col + 1];
                    char thirdChar = matrix[row + 1, col];
                    char fourthChar = matrix[row + 1, col + 1];
                    bool isEqual = firstChar == secondChar && secondChar == thirdChar && thirdChar == fourthChar;
                    if (isEqual)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
