using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, List<double>> items = new Dictionary<string, List<double>>();

            while (input[0] != "buy")
            {
                string product = input[0];
                double pricePerProduct = double.Parse(input[1]);
                double productQuantity = double.Parse(input[2]);

                if (items.ContainsKey(product))
                {
                    items[product][0] = pricePerProduct;
                    items[product][1] += productQuantity;
                }
                else
                {
                    items.Add(product, new List<double> { pricePerProduct, productQuantity });
                }
                input = Console.ReadLine().Split();
            }

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:F2}");
            }
        }
    }
}