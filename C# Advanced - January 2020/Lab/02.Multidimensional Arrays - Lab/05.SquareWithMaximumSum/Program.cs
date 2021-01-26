using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];
            int biggestSum = int.MinValue;
            int startCol = 0;
            int startRow = 0;
            int endCol = 0;
            int endRow = 0;
            

            for (int rows = 0; rows < input[0]; rows++)
            {
                int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[rows, col] = elements[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int squareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (squareSum > biggestSum)
                    {
                        biggestSum = squareSum;
                        startCol = matrix[row, col];
                        endCol = matrix[row, col + 1];
                        startRow = matrix[row + 1, col];
                        endRow = matrix[row + 1, col + 1];
                    }
                }
            }
            Console.WriteLine($"{startCol} {endCol}\n{startRow} {endRow}");
            Console.WriteLine(biggestSum);
        }
    }
}
