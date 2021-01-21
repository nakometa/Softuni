using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> playerOneCards = Console.ReadLine()
                 .Split()
       .Select(int.Parse)
                .ToList();
            List<int> playerTwoCards = Console.ReadLine()
                             .Split()
                   .Select(int.Parse)
                            .ToList();

            while (playerOneCards.Count != 0 && playerTwoCards.Count != 0)
            {
                int playerOneCard = playerOneCards[0];
                int playerTwoCard = playerTwoCards[0];

                if (playerOneCard > playerTwoCard)
                {
                    playerOneCards.Add(playerOneCard);
                    playerOneCards.Add(playerTwoCard);
                }
                else if (playerTwoCard > playerOneCard)
                {
                    playerTwoCards.Add(playerTwoCard);
                    playerTwoCards.Add(playerOneCard);
                }

                playerOneCards.RemoveAt(0);
                playerTwoCards.RemoveAt(0);
            }

            if (playerOneCards.Count != 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOneCards.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwoCards.Sum()}");
            }
        }
    }
}
