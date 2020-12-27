using System;

namespace _06.GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceForOneClothing = double.Parse(Console.ReadLine());

            //Calculations
            double priceForClothing = priceForOneClothing * statists;
            double decorPrice = budget * 0.10;

            if (statists > 150)
            {
                priceForClothing *= 0.9;
            }
            double totalPrice = decorPrice + priceForClothing;

            //Output

            if (totalPrice > budget)
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - totalPrice):F2} leva left.");
            }
        }
    }
}
