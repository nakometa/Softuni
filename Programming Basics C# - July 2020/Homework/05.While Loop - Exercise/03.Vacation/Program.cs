using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            double avalivableMoney = double.Parse(Console.ReadLine());
            int spendCounter = 0;
            int daysCounter = 0;

            while (vacationPrice > avalivableMoney)
            {
                daysCounter++;
                string input = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());

                if (input == "spend")
                {
                    spendCounter++;
                    avalivableMoney -= currentMoney;
                    if (avalivableMoney <= 0)
                    {
                        avalivableMoney = 0;
                    }
                    if (spendCounter == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCounter);
                        break;
                    }
                }
                else if (input == "save")
                {
                    spendCounter = 0;
                    avalivableMoney += currentMoney;
                }
            }
            if (avalivableMoney >= vacationPrice)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
