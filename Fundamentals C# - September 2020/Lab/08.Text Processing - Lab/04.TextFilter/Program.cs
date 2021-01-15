using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string input = Console.ReadLine();

            foreach (var word in bannedWords)
            {
                string replace = new string('*', word.Length);
                input = input.Replace(word, replace);
            }
            Console.WriteLine(input);
        }
    }
}
