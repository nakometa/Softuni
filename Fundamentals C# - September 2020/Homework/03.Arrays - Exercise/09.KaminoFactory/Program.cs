using System;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string input = string.Empty;
            string bestSequence = "";
            int bestIndex = 0;
            int bestSum = 0;
            int bestCount = 0;
            int count = 0;
            int bestPosition = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string sequence = input.Replace("!", "");
                string[] dnaParts = sequence.Split("0", StringSplitOptions.RemoveEmptyEntries);
                //
                var largestSubsequence = 0;
                var sum = 0;
                string bestDNA = "";
                if (count == 0) bestIndex = 1;
                count++;

                foreach (var dnaPart in dnaParts)
                {
                    if (dnaPart.Length > largestSubsequence)
                    {
                        largestSubsequence = dnaPart.Length;
                        bestDNA = dnaPart;
                    }
                    sum += dnaPart.Length;
                }
                int beginIndex = sequence.IndexOf(bestDNA);
                if (largestSubsequence > bestCount ||
                   (largestSubsequence == bestCount && beginIndex < bestIndex) ||
                   (largestSubsequence == bestCount && beginIndex == bestIndex && sum > bestSum))
                {
                    bestCount = largestSubsequence;
                    bestIndex = beginIndex;
                    bestSum = sum;
                    bestSequence = sequence;
                    bestPosition = count;
                }
            }
            char[] intervalSequence = bestSequence.ToCharArray();
            Console.WriteLine($"Best DNA sample {bestPosition} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", intervalSequence));
        }
    }
}
