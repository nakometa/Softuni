using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            // Calculations
            double orderPrice = (magnoliasCount * 3.25) + (hyacinthsCount * 4) + (rosesCount * 3.50) + (cactusCount * 8);
            double profitAfterTax = orderPrice - (orderPrice * 0.05);

            // Output
            if (profitAfterTax >= giftPrice)
            {
                double moneyLeft = Math.Floor(profitAfterTax - giftPrice);
                Console.WriteLine($"She is left with {moneyLeft} leva.");
            }
            else
            {
                double borrowNeeded = Math.Ceiling(giftPrice - profitAfterTax);
                Console.WriteLine($"She will have to borrow {borrowNeeded} leva.");
            }
        }
    }
}
