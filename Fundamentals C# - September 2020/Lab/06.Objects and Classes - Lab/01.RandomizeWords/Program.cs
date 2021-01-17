using System;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Random rand = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                int randomIndex = rand.Next(0, words.Length);

                words[i] = words[randomIndex];
                words[randomIndex] = word;
            }

            Console.WriteLine(string.Join("\n", words));
        }
    }
}
