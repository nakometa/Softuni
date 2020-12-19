using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double neededSum = double.Parse(Console.ReadLine());
                double totalSavedMoney = 0;
                while (neededSum > totalSavedMoney)
                {
                    double currentSave = double.Parse(Console.ReadLine());
                    totalSavedMoney += currentSave;
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
