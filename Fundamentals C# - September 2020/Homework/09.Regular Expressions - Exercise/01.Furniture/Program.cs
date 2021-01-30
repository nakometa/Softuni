using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<itemName>(\w+))<<(?<itemPrice>\d+\.?\d+)!(?<itemQuantity>\d+)";
            string input = Console.ReadLine();
            List<string> purchasedItems = new List<string>();
            double totalPrice = 0;

            while (input != "Purchase")
            {
                var regex = Regex.Match(input, pattern);
                if (regex.Success)
                {
                    purchasedItems.Add(regex.Groups["itemName"].Value);
                    totalPrice += double.Parse(regex.Groups["itemPrice"].Value) * int.Parse(regex.Groups["itemQuantity"].Value);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (purchasedItems.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, purchasedItems)}");
            }
            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
