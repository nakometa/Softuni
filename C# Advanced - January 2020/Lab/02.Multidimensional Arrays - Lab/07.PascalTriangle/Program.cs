using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];

            for (int rows = 0; rows < n; rows++)
            {
                pascalTriangle[rows] = new long[rows+1];
                for (int col = 0; col < rows + 1; col++)
                {
                    long sum = 0;
                    if (rows - 1 >= 0 && col < pascalTriangle[rows - 1].Length)
                    {
                        sum += pascalTriangle[rows - 1][col];
                    }
                    if (rows - 1 >= 0 && col - 1 >= 0)
                    {
                        sum += pascalTriangle[rows - 1][col - 1];
                    }
                    if (sum == 0)
                    {
                        sum = 1;
                    }
                    pascalTriangle[rows][col] = sum;
                }
            }

            for (int rows = 0; rows < pascalTriangle.Length; rows++)
            {
                for (int cols = 0; cols < pascalTriangle[rows].Length; cols++)
                {
                    Console.Write(pascalTriangle[rows][cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
