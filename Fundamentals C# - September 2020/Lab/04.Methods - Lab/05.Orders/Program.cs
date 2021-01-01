using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PriceCalculator(product, quantity);
        }

        static void PriceCalculator(string product, int quantity)
        {
            double pricePerProduct = 0;
            switch (product)
            {
                case "coffee":
                    pricePerProduct = 1.50;
                    Console.WriteLine($"{pricePerProduct * quantity:F2}");
                    break;
                case "water":
                    pricePerProduct = 1.00;
                    Console.WriteLine($"{pricePerProduct * quantity:F2}");
                    break;
                case "coke":
                    pricePerProduct = 1.40;
                    Console.WriteLine($"{pricePerProduct * quantity:F2}");
                    break;
                case "snacks":
                    pricePerProduct = 2.00;
                    Console.WriteLine($"{pricePerProduct * quantity:F2}");
                    break;
            }
        }
    }
}
