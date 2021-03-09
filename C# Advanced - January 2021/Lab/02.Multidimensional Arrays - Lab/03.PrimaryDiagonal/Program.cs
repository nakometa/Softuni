using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int sum = 0;

            for (int rows = 0; rows < n; rows++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[rows, col] = input[col];
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int col = rows; col < rows + 1; col++)
                {
                    sum += matrix[rows, col];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
