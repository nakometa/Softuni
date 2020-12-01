using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int totalVegetables = int.Parse(Console.ReadLine());
            int totalFruits = int.Parse(Console.ReadLine());

            double totalPrice = (vegetablesPrice * totalVegetables) + (fruitsPrice * totalFruits);
            double priceInEuro = totalPrice / 1.94;
            Console.WriteLine("{0:0.00}", priceInEuro);
        }
    }
}
