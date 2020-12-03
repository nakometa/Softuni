using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double cakePrice = 45;
            double wafflePrice = 5.8;
            double pancakePrice = 3.2;

            int campaignTime = int.Parse(Console.ReadLine());
            int totalBakers = int.Parse(Console.ReadLine());
            int numberOfCakes = int.Parse(Console.ReadLine());
            int numberOfWaffles = int.Parse(Console.ReadLine());
            int numberOfPancakes = int.Parse(Console.ReadLine());

            double totalCakesPrice = cakePrice * numberOfCakes;
            double totalWafflesPrice = wafflePrice * numberOfWaffles;
            double totalPancakesPrice = pancakePrice * numberOfPancakes;
            double totalEarningsPerDay = (totalCakesPrice + totalWafflesPrice + totalPancakesPrice) * totalBakers;
            double totalEarnings = totalEarningsPerDay * campaignTime;
            double totalEarningsWithProductsPriceIncluded = totalEarnings - (totalEarnings / 8);

            Console.WriteLine(totalEarningsWithProductsPriceIncluded);
        }
    }
}
