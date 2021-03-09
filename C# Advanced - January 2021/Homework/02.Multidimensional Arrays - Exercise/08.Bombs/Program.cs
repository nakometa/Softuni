using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] land = new int[n, n];
            int aliveCells = 0;
            long aliveSum = 0;

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    land[row, col] = rowData[col];
                }
            }

            string[] bombIndexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < bombIndexes.Count(); i++)
            {
                string[] currentBombInfo = bombIndexes[i].Split(","); 
                int bombRow = int.Parse(currentBombInfo[0]);
                int bombCol = int.Parse(currentBombInfo[1]);
                if (land[bombRow,bombCol] > 0)
                {
                    BombExplode(bombRow, bombCol, land, n);
                }
            }

            foreach (int cell in land)
            {
                if (cell > 0)
                {
                    aliveCells++;
                    aliveSum += cell;
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}\nSum: {aliveSum}");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(land[row,col] + " ");
                }
                Console.WriteLine();
            }

        }

        private static void BombExplode(int bombRow, int bombCol, int[,] land , int n)
        {
            int bombValue = land[bombRow, bombCol];
            for (int row = bombRow - 1; row < bombRow + 2; row++)
            {
                for (int col = bombCol - 1; col < bombCol + 2; col++)
                {
                    if (isValid(row, col, land, n ))
                    {
                        land[row, col] -= bombValue;
                    }
                }
            }
        }

        private static bool isValid(int checkRow, int checkCol, int[,] land, int n)
        {
            bool isValid = checkRow >= 0 && checkRow < n && checkCol >= 0 && checkCol < n && land[checkRow,checkCol] > 0;
            return isValid;
        }
    }
}
