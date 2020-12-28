using System;

namespace _07.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            var price = 0;
            bool error = false;
            switch (dayType)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                    {
                        price = 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18 || age > 64 && age <= 122)
                    {
                        price = 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine("Error!");
                    }
                    break;
                case "Holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine("Error!");
                    }
                    break;
            }
            if (!error)
            {
                Console.WriteLine(price + "$");
            }
        }
    }
}
