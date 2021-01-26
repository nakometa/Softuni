using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];

            for (int rows = 0; rows < n; rows++)
            {
                jaggedArray[rows] = new int[n];
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    jaggedArray[rows][col] = input[col];
                }
            }

            string[] cmdArgs = Console.ReadLine().Split();

            while (cmdArgs[0] != "END")
            {
                int currentRow = int.Parse(cmdArgs[1]);
                int currentCol = int.Parse(cmdArgs[2]);
                int num = int.Parse(cmdArgs[3]);
                if(currentRow >= 0 && currentRow < n && currentCol >= 0 && currentCol < n)
                {
                    if (cmdArgs[0] == "Subtract")
                    {
                        jaggedArray[currentRow][currentCol] -= num;
                    }
                    else
                    {
                        jaggedArray[currentRow][currentCol] += num;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
                cmdArgs = Console.ReadLine().Split();
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
