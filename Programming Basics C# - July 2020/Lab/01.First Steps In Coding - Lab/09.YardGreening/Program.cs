using System;

namespace _09.YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double gardeningSpace = double.Parse(Console.ReadLine());
            double price = gardeningSpace * 7.61;
            double priceAfterDiscount = price - price * 0.18;
            double discount = price * 0.18;

            Console.WriteLine($"The final price is: {priceAfterDiscount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
