using System;

namespace _04.SymbolinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];
            bool found = false;
            int matchingRow = 0;
            int matchingCol = 0;

            for (int rows = 0; rows < n; rows++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    char currentChar = input[col];
                    matrix[rows, col] = currentChar;
                }
            }
            string symbol = Console.ReadLine();

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    if (matrix[rows,cols].ToString() == symbol)
                    {
                        matchingRow = rows;
                        matchingCol = cols;
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"({matchingRow}, {matchingCol})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
