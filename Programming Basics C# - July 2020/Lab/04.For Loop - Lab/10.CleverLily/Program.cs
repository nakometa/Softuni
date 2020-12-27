using System;

namespace _10.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double toysRecieved = 0;
            double moneyCollected = 0;
            double money = 0;

            // Output 
            for (int i = 1; i <= age; i++)
            {
                money += 5;
                if (i % 2 == 0)
                {
                    moneyCollected += money;
                }
                else
                {
                    toysRecieved += 1;
                }
            }
            moneyCollected = moneyCollected + (toysRecieved * toysPrice) - (age / 2);

            if (moneyCollected >= washingMachinePrice)
            {
                double moneyLeft = moneyCollected - washingMachinePrice;
                Console.WriteLine($"Yes! {moneyLeft:F2}");
            }
            else
            {
                double moneyNeeded = washingMachinePrice - moneyCollected;
                Console.WriteLine($"No! {moneyNeeded:F2}");
            }

        }
    }
}
