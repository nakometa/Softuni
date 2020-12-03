using System;

namespace _03.DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositMonths = int.Parse(Console.ReadLine());
            double yearlyInterest = double.Parse(Console.ReadLine());

            double interest = depositSum * yearlyInterest / 100;
            double monthlyInterest = interest / 12;
            double totalSum = depositSum + (depositMonths * monthlyInterest);

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
