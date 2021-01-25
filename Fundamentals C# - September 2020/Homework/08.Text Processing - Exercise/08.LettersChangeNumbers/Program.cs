using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];
                char firstChar = curr[0];
                char lastChar = curr[curr.Length - 1];
                double num = double.Parse(curr.Substring(1, curr.Length - 2));

                int firstElementIndex = alpha.IndexOf(char.ToUpper(firstChar));
                int secondElementIndex = alpha.IndexOf(char.ToUpper(lastChar));

                if (char.IsUpper(firstChar))
                {
                    num = num / (firstElementIndex + 1);
                }
                else
                {
                    num = num * (firstElementIndex + 1);
                }

                if (char.IsUpper(lastChar))
                {
                    num = num - (secondElementIndex + 1);
                }
                else
                {
                    num = num + (secondElementIndex + 1);
                }
                sum += num;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}