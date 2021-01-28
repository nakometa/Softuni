using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jaggedArray[row] = rowData;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                var firstRow = jaggedArray[row];
                var secondRow = jaggedArray[row + 1];

                if (firstRow.Length == secondRow.Length)
                {
                    jaggedArray[row] = firstRow.Select(m => m * 2).ToArray();
                    jaggedArray[row +1] = secondRow.Select(m => m * 2).ToArray();
                }
                else
                {
                    jaggedArray[row] = firstRow.Select(m => m / 2).ToArray();
                    jaggedArray[row + 1] = secondRow.Select(m => m / 2).ToArray();
                }
            }

            string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (cmdArgs[0] != "End")
            {
                int row = int.Parse(cmdArgs[1]);
                int col = int.Parse(cmdArgs[2]);
                if (isValid(row, col, rows, jaggedArray))
                {
                    switch (cmdArgs[0])
                    {
                        case "Add":
                            jaggedArray[row][col] += double.Parse(cmdArgs[3]);
                            break;
                        case "Subtract":
                            jaggedArray[row][col] -= double.Parse(cmdArgs[3]);
                            break;
                    }
                }
                cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ") ;
                }
                Console.WriteLine();
            }
        }

        private static bool isValid(int row, int col, int rows, double[][] jaggedArray)
        {
            bool isRowValid = row >= 0 && row < rows;
            bool isColValid = false;
            if (isRowValid)
            {
                isColValid = col >= 0 && col < jaggedArray[row].Length;
            }
            bool bothValid = isRowValid && isColValid;
            return bothValid;
        }
    }
}
