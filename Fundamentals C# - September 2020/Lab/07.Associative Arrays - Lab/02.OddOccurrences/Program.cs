using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> oddOccurences = new Dictionary<string, int>();

            foreach (var item in input)
            {
                string wordInLowerCase = item.ToLower();
                if (oddOccurences.ContainsKey(wordInLowerCase))
                {
                    oddOccurences[wordInLowerCase]++;
                }
                else
                {
                    oddOccurences.Add(wordInLowerCase, 1);
                }
            }

            foreach (var word in oddOccurences)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key + " "}");
                }
            }
        }
    }
}
