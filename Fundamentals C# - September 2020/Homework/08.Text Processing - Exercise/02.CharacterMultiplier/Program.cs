using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstWord = input[0];
            string secondWord = input[1];

            string longestWord = firstWord;
            string shortestWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }
            int total = CharManipulator(longestWord, shortestWord);

            Console.WriteLine(total);

        }

        public static int CharManipulator(string longestWord, string shortestWord)
        {
            int sum = 0;
            for (int i = 0; i < shortestWord.Length; i++)
            {
                int multiply = shortestWord[i] * longestWord[i];
                sum += multiply;
            }

            for (int i = shortestWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }
            return sum;
        }
    }
}
