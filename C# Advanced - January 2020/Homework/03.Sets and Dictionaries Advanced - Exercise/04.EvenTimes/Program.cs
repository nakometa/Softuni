using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> evenTimesNumber = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!evenTimesNumber.ContainsKey(number))
                {
                    evenTimesNumber.Add(number, 0);
                }
                evenTimesNumber[number]++;
            }
            foreach (var item in evenTimesNumber)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
