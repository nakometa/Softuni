using System;

namespace _01.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            const double normalPrice = 249.99;
            const double vipPrice = 499.99;

            // Input
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            // Calculations 
            double transportPrice = 0;
            double ticketPrice = 0;
            double totalPrice = 0;
            if (numberOfPeople >= 1 && numberOfPeople <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (numberOfPeople >= 4 && numberOfPeople <= 9)
            {
                transportPrice = budget * 0.6;
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                transportPrice = budget * 0.5;
            }
            else if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                transportPrice = budget * 0.4;
            }
            else
            {
                transportPrice = budget * 0.25;
            }

            if (category == "Normal")
            {
                ticketPrice = numberOfPeople * normalPrice;
                totalPrice = ticketPrice + transportPrice;
                if (totalPrice <= budget)
                {
                    double moneyLeft = budget - totalPrice;
                    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
                }
                else
                {
                    double moneyNeeded = totalPrice - budget;
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }
            }
            else
            {
                ticketPrice = numberOfPeople * vipPrice;
                totalPrice = ticketPrice + transportPrice;
                if (totalPrice <= budget)
                {
                    double moneyLeft = budget - totalPrice;
                    Console.WriteLine($"Yes! You have {moneyLeft:F2} leva left.");
                }
                else
                {
                    double moneyNeeded = totalPrice - budget;
                    Console.WriteLine($"Not enough money! You need {moneyNeeded:F2} leva.");
                }
            }
        }
    }
}
