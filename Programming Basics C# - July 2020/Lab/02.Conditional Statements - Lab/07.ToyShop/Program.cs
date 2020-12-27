using System;

namespace _07.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double moneyLeft = 0;

            int toysOrder = puzzles + dolls + bears + minions + trucks;
            double totalPrice = (puzzles * 2.6) + (dolls * 3) + (bears * 4.1) + (minions * 8.2) + (trucks * 2);
            double priceAfterRent = totalPrice - (totalPrice * 0.10);

            if (toysOrder >= 50)
            {
                priceAfterRent *= 0.75;
            }

            if (priceAfterRent >= tripPrice)
            {
                moneyLeft = priceAfterRent - tripPrice;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                moneyLeft = tripPrice - priceAfterRent;
                Console.WriteLine($"Not enough money! {moneyLeft:F2} lv needed.");
            }
        }
    }
}
