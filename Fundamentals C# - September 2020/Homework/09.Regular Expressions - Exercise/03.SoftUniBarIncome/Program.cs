using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>[0-9]+)\|[^|$%.]*?(?<price>\d+\.?\d*)\$";
            string input = Console.ReadLine();
            double income = 0;

            while (input != "end of shift")
            {
                Match regex = Regex.Match(input, pattern);
                if (regex.Success)
                {
                    string customer = regex.Groups["name"].Value;
                    string product = regex.Groups["product"].Value;
                    int quantity = int.Parse(regex.Groups["quantity"].Value);
                    double price = double.Parse(regex.Groups["price"].Value);
                    double totalPrice = price * quantity;
                    income += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:F2}");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}