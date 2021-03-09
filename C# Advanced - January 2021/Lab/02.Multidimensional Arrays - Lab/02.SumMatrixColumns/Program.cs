using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];
            int sum = 0;

            for (int row = 0; row < input[0]; row++)
            {
                int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            for (int col = 0; col < input[1]; col++)
            {
                sum = 0;
                for (int row = 0; row < input[0]; row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
