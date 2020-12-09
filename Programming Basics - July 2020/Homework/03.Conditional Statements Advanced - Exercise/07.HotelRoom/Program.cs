using System;

namespace _07.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prices
            const double mayAndOctoberStudioPrice = 50;
            const double mayAndOctoberApartmentPrice = 65;
            const double juneAndSeptemberStudioPrice = 75.20;
            const double juneAndSeptemberApartmentPrice = 68.70;
            const double julyAndAugustApartmentPrice = 77;
            const double julyAndAugustStudioPrice = 76;

            // Input
            string month = Console.ReadLine();
            int stayNights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double apartmentPrice = 0;

            if (month == "October" || month == "May")
            {
                studioPrice = mayAndOctoberStudioPrice * stayNights;
                apartmentPrice = mayAndOctoberApartmentPrice * stayNights;

                if (stayNights > 7 && stayNights <= 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if (stayNights > 14)
                {
                    studioPrice -= studioPrice * 0.3;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = juneAndSeptemberStudioPrice * stayNights;
                apartmentPrice = juneAndSeptemberApartmentPrice * stayNights;

                if (stayNights > 14)
                {
                    studioPrice -= studioPrice * 0.2;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = julyAndAugustStudioPrice * stayNights;
                apartmentPrice = julyAndAugustApartmentPrice * stayNights;
            }

            if (stayNights > 14)
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
