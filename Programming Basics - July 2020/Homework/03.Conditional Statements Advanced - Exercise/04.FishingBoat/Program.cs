using System;

namespace _04.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            const int springPrice = 3000;
            const int autumnAndSummerPrice = 4200;
            const int winterPrice = 2600;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishemanNumber = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            switch (season)
            {
                case "Spring":
                    totalPrice = springPrice;
                    break;
                case "Summer":
                    totalPrice = autumnAndSummerPrice;
                    break;
                case "Autumn":
                    totalPrice = autumnAndSummerPrice;
                    break;
                case "Winter":
                    totalPrice = winterPrice;
                    break;
            }

            if (fishemanNumber <= 6)
            {
                totalPrice = totalPrice * 0.9;
            }
            else if (fishemanNumber > 7 && fishemanNumber <= 11)
            {
                totalPrice = totalPrice * 0.85;
            }
            else
            {
                totalPrice = totalPrice * 0.75;
            }

            if (fishemanNumber % 2 == 0 && season != "Autumn")
            {
                totalPrice = totalPrice * 0.95;
            }

            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
            }
        }
    }
}
