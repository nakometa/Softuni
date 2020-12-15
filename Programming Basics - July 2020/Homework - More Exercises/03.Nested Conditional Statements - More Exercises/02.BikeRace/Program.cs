using System;

namespace _02.BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int juniorCyclers = int.Parse(Console.ReadLine());
            int seniorCyclers = int.Parse(Console.ReadLine());
            string mapType = Console.ReadLine();
            double juniorsPrice = 0;
            double seniorsPrice = 0;
            double totalPrice = 0;

            switch (mapType)
            {
                case "trail":
                    juniorsPrice = juniorCyclers * 5.5;
                    seniorsPrice = seniorCyclers * 7;
                    totalPrice = juniorsPrice + seniorsPrice;
                    break;
                case "cross-country":
                    juniorsPrice = juniorCyclers * 8;
                    seniorsPrice = seniorCyclers * 9.5;
                    totalPrice = juniorsPrice + seniorsPrice;
                    if (juniorCyclers + seniorCyclers >= 50)
                    {
                        totalPrice = totalPrice * 0.75;
                    }
                    break;
                case "downhill":
                    juniorsPrice = juniorCyclers * 12.25;
                    seniorsPrice = seniorCyclers * 13.75;
                    totalPrice = juniorsPrice + seniorsPrice;
                    break;
                case "road":
                    juniorsPrice = juniorCyclers * 20;
                    seniorsPrice = seniorCyclers * 21.50;
                    totalPrice = juniorsPrice + seniorsPrice;
                    break;
            }
            double totalPriceAfterTax = totalPrice - (totalPrice * 0.05);
            Console.WriteLine($"{totalPriceAfterTax:F2}");
        }
    }
}
