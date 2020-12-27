using System;

namespace _11.HappyCatParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double currentTax = 0;
            double totalAmount = 0;


            for (int i = 1; i <= days; i++)
            {
                bool evenDay = false;
                bool oddDay = false;
                double amountForTheDay = 0;
                if (i % 2 == 0)
                {
                    evenDay = true;
                }
                else
                {
                    oddDay = true;
                }
                for (int j = 1; j <= hours; j++)
                {
                    bool oddHour = false;
                    bool evenHour = false;
                    if (j % 2 == 0)
                    {
                        evenHour = true;
                    }
                    else
                    {
                        oddHour = true;
                    }
                    if (evenDay && oddHour)
                    {
                        currentTax = 2.50;
                    }
                    else if (oddDay && evenHour)
                    {
                        currentTax = 1.25;
                    }
                    else
                    {
                        currentTax = 1;
                    }
                    amountForTheDay += currentTax;
                    totalAmount += currentTax;
                }
                Console.WriteLine($"Day: {i} - {amountForTheDay:F2} leva");
            }
            Console.WriteLine($"Total: {totalAmount:F2} leva");
        }
    }
}
