using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "END")
            {
                if (cmdArgs[0] != "swap" || cmdArgs.Count() > 5 || cmdArgs.Count() < 4)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int index1 = int.Parse(cmdArgs[1]);
                    int col1 = int.Parse(cmdArgs[2]);
                    int index2 = int.Parse(cmdArgs[3]);
                    int col2 = int.Parse(cmdArgs[4]);

                    if (CheckIndexes(index1, col1, index2, col2, n, m))
                    {
                        string secondElement = matrix[index2, col2];
                        matrix[index2, col2] = matrix[index1,col1];
                        matrix[index1, col1] = secondElement;

                        for (int row = 0; row < n; row++)
                        {
                            for (int col = 0; col < m; col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                cmdArgs = Console.ReadLine().Split();
            }
        }

        private static bool CheckIndexes(int index1, int col1, int index2, int col2, int n, int m)
        {
            bool isFirstValid = index1 >= 0 && index1 < n && col1 >= 0 && col1 < m;
            bool isSecondValid = index2 >= 0 && index2 < n && col2 >= 0 && col2 < m;
            bool result = isFirstValid && isSecondValid;
            return result;
        }
    }
}
