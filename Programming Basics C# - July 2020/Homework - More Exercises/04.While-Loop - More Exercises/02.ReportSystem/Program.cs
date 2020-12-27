using System;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int expectedSum = int.Parse(Console.ReadLine());
            int collectedSum = 0;
            int i = 1;
            int collectedByCC = 0;
            int collectedByCS = 0;
            int counterCC = 0;
            int counterCS = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {
                int currentDonation = int.Parse(input);
                if (i % 2 == 0)
                {
                    if (currentDonation >= 10)
                    {
                        collectedSum += currentDonation;
                        collectedByCC += currentDonation;
                        counterCC++;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                else
                {
                    if (currentDonation <= 100)
                    {
                        collectedSum += currentDonation;
                        collectedByCS += currentDonation;
                        counterCS++;
                        Console.WriteLine("Product sold!");
                    }
                    else
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                }
                if (collectedSum >= expectedSum)
                {
                    Console.WriteLine($"Average CS: {collectedByCS * 1.0 / counterCS:F2}");
                    Console.WriteLine($"Average CC: {collectedByCC * 1.0 / counterCC:F2}");
                    break;
                }
                i++;
                input = Console.ReadLine();
            }
            if (collectedSum < expectedSum)
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
