using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPairs = int.Parse(Console.ReadLine());
            var pairs = new Dictionary<string, List<string>>();

            for (int i = 0; i < amountOfPairs; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (pairs.ContainsKey(word))
                {
                    pairs[word].Add(synonim);
                }
                else
                {
                    pairs.Add(word, new List<string>() { synonim });
                }
            }

            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Key} - {String.Join(", ", pair.Value)}");
            }
        }
    }
}
