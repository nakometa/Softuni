using System;

namespace _07.SchoolCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int students = int.Parse(Console.ReadLine());
            int stayTime = int.Parse(Console.ReadLine());
            double totalPrice = 0;
            string sports = "";

            // Calculations
            switch (groupType)
            {
                case "boys":
                    switch (season)
                    {
                        case "Winter":
                            totalPrice = 9.60 * students * stayTime;
                            sports = "Judo";
                            break;
                        case "Spring":
                            totalPrice = 7.20 * students * stayTime;
                            sports = "Tennis";
                            break;
                        case "Summer":
                            totalPrice = 15 * students * stayTime;
                            sports = "Football";
                            break;
                    }
                    break;
                case "girls":
                    switch (season)
                    {
                        case "Winter":
                            totalPrice = 9.60 * students * stayTime;
                            sports = "Gymnastics";
                            break;
                        case "Spring":
                            totalPrice = 7.20 * students * stayTime;
                            sports = "Athletics";
                            break;
                        case "Summer":
                            totalPrice = 15 * students * stayTime;
                            sports = "Volleyball";
                            break;
                    }
                    break;
                case "mixed":
                    switch (season)
                    {
                        case "Winter":
                            totalPrice = 10 * students * stayTime;
                            sports = "Ski";
                            break;
                        case "Spring":
                            totalPrice = 9.50 * students * stayTime;
                            sports = "Cycling";
                            break;
                        case "Summer":
                            totalPrice = 20 * students * stayTime;
                            sports = "Swimming";
                            break;
                    }
                    break;
            }
            if (students >= 10 && students < 20)
            {
                totalPrice = totalPrice * 0.95;
            }
            else if (students >= 20 && students < 50)
            {
                totalPrice = totalPrice * 0.85;
            }
            else if (students >= 50)
            {
                totalPrice = totalPrice * 0.5;
            }
            Console.WriteLine($"{sports} {totalPrice:F2} lv.");
        }
    }
}
