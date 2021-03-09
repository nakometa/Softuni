using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            char[,] field = new char[n, m];
            int playerRow = 0;
            int playerCol = 0;
            string playerStatus = string.Empty;


            for (int row = 0; row < n; row++)
            {
                char[] rowData = Console.ReadLine().ToCharArray();
                for (int col = 0; col < m; col++)
                {
                    field[row, col] = rowData[col];
                    if (rowData[col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            char[] commands = Console.ReadLine().ToCharArray();

            for (int i = 0; i < commands.Count(); i++)
            {
                char currentCommand = commands[i];
                int futureRow = playerRow;
                int futureCol = playerCol;
                if (currentCommand == 'U')
                {
                    futureRow--;
                }
                else if (currentCommand == 'D')
                {
                    futureRow++;
                }
                else if (currentCommand == 'L')
                {
                    futureCol--;
                }
                else if (currentCommand == 'R')
                {
                    futureCol++;
                }

                if (IsInField(futureRow, futureCol, field))
                {
                    char nextStep = field[futureRow, futureCol];

                    if (nextStep == '.')
                    {
                        field[futureRow, futureCol] = 'P';
                        field[playerRow, playerCol] = '.';
                        playerRow = futureRow;
                        playerCol = futureCol;
                    }
                    else if (nextStep == 'B')
                    {
                        playerStatus = "dead";
                        playerRow = futureRow;
                        playerCol = futureCol;
                    }
                }
                else
                {
                    playerStatus = "won";
                    field[playerRow, playerCol] = '.';
                }

                playerStatus = SpreadBunnies(field, playerStatus);

                if (playerStatus != "won" && field[playerRow,playerCol] == 'B')
                {
                    playerStatus = "dead";
                }

                if (playerStatus == "won" || playerStatus == "dead")
                {
                    break;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{playerStatus}: {playerRow} {playerCol}");
        }


        private static string SpreadBunnies(char[,] field, string playerStatus)
        {
            List<int> bunnyLocations = new List<int>();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row,col] == 'B')
                    {
                        bunnyLocations.Add(row);
                        bunnyLocations.Add(col);
                    }
                }
            }

            for (int i = 0; i < bunnyLocations.Count; i += 2)
            {
                int currentBunnyRow = bunnyLocations[i];
                int currentBunnyCol = bunnyLocations[i + 1];
                SpreadBunny(currentBunnyCol, currentBunnyRow, field, playerStatus);
            }
            return playerStatus;
        }

        private static void SpreadBunny(int currentBunnyCol, int currentBunnyRow, char[,] field, string playerStatus)
        {
            if (IsInField(currentBunnyRow - 1, currentBunnyCol, field))
            {
                field[currentBunnyRow - 1, currentBunnyCol] = 'B';
            }
            if (IsInField(currentBunnyRow + 1, currentBunnyCol, field))
            {
                field[currentBunnyRow + 1, currentBunnyCol] = 'B';
            }
            if (IsInField(currentBunnyRow, currentBunnyCol - 1, field))
            {
                field[currentBunnyRow, currentBunnyCol - 1] = 'B';
            }
            if (IsInField(currentBunnyRow, currentBunnyCol + 1, field))
            {
                field[currentBunnyRow, currentBunnyCol + 1] = 'B';
            }
        }

        private static bool IsInField(int futureRow, int futureCol, char[,] field)
        {
            bool valid = futureRow >= 0 && futureRow < field.GetLength(0) && futureCol >= 0 && futureCol < field.GetLength(1);
            return valid;
        }
    }
}
