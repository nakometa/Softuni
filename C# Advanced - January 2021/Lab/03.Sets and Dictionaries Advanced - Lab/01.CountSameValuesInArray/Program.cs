using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> digits = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (digits.ContainsKey(input[i]))
                {
                    digits[input[i]]++;
                }
                else
                {
                    digits.Add(input[i], 1);
                }
            }

            foreach (var item in digits)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
