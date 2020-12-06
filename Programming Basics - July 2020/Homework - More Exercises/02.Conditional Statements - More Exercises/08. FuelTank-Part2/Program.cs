using System;

namespace _08._FuelTank_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelAmount = double.Parse(Console.ReadLine());
            string discountCard = Console.ReadLine();

            // Calculations
            double totalPrice = 0;
            double finalPrice = 0;

            switch (fuelType)
            {
                case "Gas":
                    if (discountCard == "Yes" && fuelAmount < 20)
                    {
                        finalPrice = fuelAmount * (0.93 - 0.08);
                    }
                    else if (discountCard == "Yes" && fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        totalPrice = fuelAmount * (0.93 - 0.08);
                        double discount = totalPrice * 0.08;
                        finalPrice = totalPrice - discount;
                    }
                    else if (discountCard == "Yes" && fuelAmount > 25)
                    {
                        totalPrice = fuelAmount * (0.93 - 0.08);
                        double discount = totalPrice * 0.1;
                        finalPrice = totalPrice - discount;
                    }
                    else if (discountCard == "No" && fuelAmount < 20)
                    {
                        finalPrice = fuelAmount * 0.93;
                    }
                    else if (discountCard == "No" && fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        totalPrice = fuelAmount * 0.93;
                        double discount = totalPrice * 0.08;
                        finalPrice = totalPrice - discount;
                    }
                    else if (discountCard == "No" && fuelAmount > 25)
                    {
                        totalPrice = fuelAmount * 0.93;
                        double discount = totalPrice * 0.1;
                        finalPrice = totalPrice - discount;
                    }
                    break;
                case "Gasoline":
                    if (discountCard == "Yes" && fuelAmount < 20)
                    {
                        finalPrice = fuelAmount * (2.22 - 0.18);
                    }
                    else if (discountCard == "Yes" && fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        totalPrice = fuelAmount * (2.22 - 0.18);
                        double discount = totalPrice * 0.08;
                        finalPrice = totalPrice - discount;
                    }
                    else if (discountCard == "Yes" && fuelAmount > 25)
                    {
                        totalPrice = fuelAmount * (2.22 - 0.18);
                        double discount = totalPrice * 0.1;
                        finalPrice = totalPrice - discount;
                    }
                    else if (discountCard == "No" && fuelAmount < 20)
                    {
                        finalPrice = fuelAmount * 2.22;
                    }
                    else if (discountCard == "No" && fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        totalPrice = fuelAmount * 2.22;
                        double discount = totalPrice * 0.08;
                        finalPrice = totalPrice - discount;
                    }
                    else if (discountCard == "No" && fuelAmount > 25)
                    {
                        totalPrice = fuelAmount * 2.22;
                        double discount = totalPrice * 0.1;
                        finalPrice = totalPrice - discount;
                    }
                    break;
                case "Diesel":
                    if (discountCard == "Yes" && fuelAmount < 20)
                    {
                        finalPrice = fuelAmount * (2.33 - 0.12);
                    }
                    else if (discountCard == "Yes" && fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        totalPrice = fuelAmount * (2.33 - 0.12);
                        double discount = totalPrice * 0.08;
                        finalPrice = totalPrice - discount;
                    }
                    else if (discountCard == "Yes" && fuelAmount > 25)
                    {
                        totalPrice = fuelAmount * (2.33 - 0.12);
                        double discount = totalPrice * 0.1;
                        finalPrice = totalPrice - discount;
                    }
                    else if (discountCard == "No" && fuelAmount < 20)
                    {
                        finalPrice = fuelAmount * 2.33;
                    }
                    else if (discountCard == "No" && fuelAmount >= 20 && fuelAmount <= 25)
                    {
                        totalPrice = fuelAmount * 2.33;
                        double discount = totalPrice * 0.08;
                        finalPrice = totalPrice - discount;
                    }
                    else if (discountCard == "No" && fuelAmount > 25)
                    {
                        totalPrice = fuelAmount * 2.33;
                        double discount = totalPrice * 0.1;
                        finalPrice = totalPrice - discount;
                    }
                    break;
            }
            Console.WriteLine($"{finalPrice:F2} lv.");
        }
    }
}
