using System;

namespace _06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int totalPiecesTaken = 0;
            int cakePieces = width * length;
            string input = Console.ReadLine();

            while (input != "STOP")
            {
                int piecesTaken = int.Parse(input);
                totalPiecesTaken += piecesTaken;

                if (cakePieces <= totalPiecesTaken)
                {
                    int piecesNeeded = totalPiecesTaken - cakePieces;
                    Console.WriteLine($"No more cake left! You need {piecesNeeded} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }

            if (cakePieces > totalPiecesTaken)
            {
                int piecesLeft = cakePieces - totalPiecesTaken;
                Console.WriteLine($"{piecesLeft} pieces are left.");
            }
        }
    }
}
