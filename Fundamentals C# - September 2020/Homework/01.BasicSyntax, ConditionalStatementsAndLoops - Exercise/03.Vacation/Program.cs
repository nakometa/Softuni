using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var groupType = Console.ReadLine();
            var day = Console.ReadLine();

            var pricePerPerson = 0.0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 8.45;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 9.80;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 10.46;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 10.90;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 15.60;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 16;
                }
            }
            else
            {
                if (day == "Friday")
                {
                    pricePerPerson = 15;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 20;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 22.50;
                }
            }

            if (groupType == "Students" && people >= 30)
            {
                pricePerPerson *= 0.85;
            }
            else if (groupType == "Business" && people >= 100)
            {
                people -= 10;
            }
            else if (groupType == "Regular" && people >= 10 && people <= 20)
            {
                pricePerPerson *= 0.95;
            }

            var totalPrice = pricePerPerson * people;
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
