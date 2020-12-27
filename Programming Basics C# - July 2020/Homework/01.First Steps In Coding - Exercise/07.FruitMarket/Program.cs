using System;

namespace _07.FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double amountOfBananas = double.Parse(Console.ReadLine());
            double amountOfOranges = double.Parse(Console.ReadLine());
            double amountOfRaspberrys = double.Parse(Console.ReadLine());
            double amountOfStrawberrys = double.Parse(Console.ReadLine());

            double raspberryPrice = strawberryPrice - (strawberryPrice * 0.5);
            double orangePrice = raspberryPrice - (raspberryPrice * 0.4);
            double bananaPrice = raspberryPrice - (raspberryPrice * 0.8);

            double totalStrawberryPrice = amountOfStrawberrys * strawberryPrice;
            double totalBananaPrice = amountOfBananas * bananaPrice;
            double totalOrangePrice = amountOfOranges * orangePrice;
            double totalRaspberryPrice = amountOfRaspberrys * raspberryPrice;
            double totalSum = totalStrawberryPrice + totalBananaPrice + totalOrangePrice + totalRaspberryPrice;

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
