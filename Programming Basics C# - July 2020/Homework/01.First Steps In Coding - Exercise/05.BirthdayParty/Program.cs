using System;

namespace _05.BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallPrice = double.Parse(Console.ReadLine());
            double cakePrice = hallPrice * 0.2;
            double drinksPrice = cakePrice - (cakePrice * 0.45);
            double animatorPrice = hallPrice / 3;

            double totalSumNeeded = hallPrice + cakePrice + drinksPrice + animatorPrice;
            Console.WriteLine(totalSumNeeded);
        }
    }
}
