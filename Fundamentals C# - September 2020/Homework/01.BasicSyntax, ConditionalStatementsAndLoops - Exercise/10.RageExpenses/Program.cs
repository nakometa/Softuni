using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());
            var money = 0.0;
            //
            money += headsetPrice * (lostGames / 2) + mousePrice * (lostGames / 3) + keyboardPrice * (lostGames / 6) + displayPrice * (lostGames / 12);
            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}
