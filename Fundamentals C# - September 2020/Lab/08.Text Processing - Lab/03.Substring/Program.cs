using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeWord = Console.ReadLine().ToLower();
            string sequence = Console.ReadLine();
            int removeIndex = sequence.IndexOf(removeWord);

            while (removeIndex != -1)
            {
                sequence = sequence.Remove(removeIndex, removeWord.Length);
                removeIndex = sequence.IndexOf(removeWord);
            }

            Console.WriteLine(sequence);
        }
    }
}
