using System;

namespace _13.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int stayTime = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            double pricePerNight = 0;
            // Calculations
            int totalNights = stayTime - 1;
            if (roomType == "room for one person")
            {
                pricePerNight = 18.00;
            }
            else if (roomType == "apartment")
            {
                pricePerNight = 25.00;
            }
            else if (roomType == "president apartment")
            {
                pricePerNight = 35.00;
            }
            double priceWithoutDiscount = pricePerNight * totalNights;
            double discount = 0;

            if (roomType == "apartment")
            {
                if (stayTime < 10)
                {
                    discount = 0.3;
                }
                else if (stayTime >= 10 && stayTime <= 15)
                {
                    discount = 0.35;
                }
                else if (stayTime > 15)
                {
                    discount = 0.5;
                }

            }
            else if (roomType == "president apartment")
            {
                if (stayTime < 10)
                {
                    discount = 0.1;
                }
                else if (stayTime >= 10 && stayTime <= 15)
                {
                    discount = 0.15;
                }
                else if (stayTime > 15)
                {
                    discount = 0.2;
                }
            }
            double priceAfterDiscount = priceWithoutDiscount - (priceWithoutDiscount * discount);

            if (feedback == "positive")
            {
                priceAfterDiscount = priceAfterDiscount + (priceAfterDiscount * 0.25);
            }
            else if (feedback == "negative")
            {
                priceAfterDiscount = priceAfterDiscount - (priceAfterDiscount * 0.1);
            }

            Console.WriteLine($"{priceAfterDiscount:F2}");
        }
    }
}
