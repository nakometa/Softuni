using System;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int playerRow = 0;
            int playerCol = 0;
            int coalCounter = 0;
            bool playerWin = false;
            bool gameOver = false;

            for (int row = 0; row < n; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = char.Parse(rowData[col]);
                    if (rowData[col] == "s")
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    else if (field[row,col] == 'c')
                    {
                        coalCounter++;
                    }
                }
            }

            for (int i = 0; i < commands.Count(); i++)
            {
                string direction = commands[i];
                int futureRow = playerRow;
                int futureCol = playerCol;

                if (direction == "up")
                {
                    futureRow -= 1;
                }
                else if (direction == "down")
                {
                    futureRow += 1;
                }
                else if (direction == "left")
                {
                    futureCol -= 1;
                }
                else
                {
                    futureCol += 1;
                }
                
                if (InsideField(futureRow, futureCol, field, n))
                {
                    char nextPos = field[futureRow, futureCol];

                    if (nextPos == '*')
                    {
                        field[playerRow, playerCol] = '*';
                        field[futureRow, futureCol] = 's';
                        playerRow = futureRow;
                        playerCol = futureCol;
                    }
                    else if (nextPos == 'c')
                    {
                        field[playerRow, playerCol] = '*';
                        field[futureRow, futureCol] = 's';
                        playerRow = futureRow;
                        playerCol = futureCol;
                        coalCounter--;
                        if (coalCounter == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({futureRow}, {futureCol})");
                            playerWin = true;
                            break;
                        }
                    }
                    else if (nextPos == 'e')
                    {
                        Console.WriteLine($"Game over! ({futureRow}, {futureCol})");
                        gameOver = true;
                        break;
                    }
                }
            }

            if (!gameOver && !playerWin)
            {
                Console.WriteLine($"{coalCounter} coals left. ({playerRow}, {playerCol})");
            }
        }

        private static bool InsideField(int futureRow, int futureCol, char[,] field, int n)
        {
            bool isInField = futureRow >= 0 && futureRow < n && futureCol >= 0 && futureCol < n;
            return isInField;
        }
    }
}
