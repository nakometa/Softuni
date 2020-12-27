using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prices
            const double chrysanthemumsSpringAndSummerPrice = 2.00;
            const double chrysanthemumsAutumnAndWinterPrice = 3.75;
            const double rosesSpringAndSummerPrice = 4.10;
            const double rosesAutumnAndWinterPrice = 4.50;
            const double tulipsSpringAndSummerPrice = 2.50;
            const double tulipsAutumnAndWinterPrice = 4.15;

            // Input
            int purchasedChrysanthemums = int.Parse(Console.ReadLine());
            int purchasedRoses = int.Parse(Console.ReadLine());
            int purchasedTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string isItHoliday = Console.ReadLine();
            double totalPrice = 0;

            // Calculations
            if (season == "Spring")
            {
                totalPrice = (purchasedChrysanthemums * chrysanthemumsSpringAndSummerPrice) + (purchasedRoses * rosesSpringAndSummerPrice) + (tulipsSpringAndSummerPrice * purchasedTulips);
                if (purchasedTulips > 7)
                {
                    totalPrice = totalPrice * 0.95;
                }
            }
            else if (season == "Summer")
            {
                totalPrice = (purchasedChrysanthemums * chrysanthemumsSpringAndSummerPrice) + (purchasedRoses * rosesSpringAndSummerPrice) + (tulipsSpringAndSummerPrice * purchasedTulips);
            }
            else if (season == "Winter")
            {
                totalPrice = (purchasedChrysanthemums * chrysanthemumsAutumnAndWinterPrice) + (purchasedRoses * rosesAutumnAndWinterPrice) + (purchasedTulips * tulipsAutumnAndWinterPrice);
                if (purchasedRoses >= 10)
                {
                    totalPrice = totalPrice * 0.9;
                }
            }
            else if (season == "Autumn")
            {
                totalPrice = (purchasedChrysanthemums * chrysanthemumsAutumnAndWinterPrice) + (purchasedRoses * rosesAutumnAndWinterPrice) + (purchasedTulips * tulipsAutumnAndWinterPrice);
            }

            if (isItHoliday == "Y")
            {
                totalPrice = totalPrice * 1.15;
            }
            if (purchasedChrysanthemums + purchasedRoses + purchasedTulips > 20)
            {
                totalPrice = totalPrice * 0.8;
            }
            double totalPriceAfterPacking = totalPrice + 2;
            Console.WriteLine($"{totalPriceAfterPacking:F2}");
        }
    }
}
