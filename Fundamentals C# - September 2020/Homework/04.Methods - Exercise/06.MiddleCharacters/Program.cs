using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;
            if (input.Length % 2 == 0)
            {
                output = GetEvenMiddleCharacters(input);
            }
            else
            {
                output = GetOddMiddleCharacter(input);
            }
            Console.WriteLine(output);
        }

        private static string GetOddMiddleCharacter(string text)
        {
            int index = text.Length / 2;
            string middleChars = text.Substring(index, 1);
            return middleChars;
        }

        private static string GetEvenMiddleCharacters(string text)
        {
            int index = (text.Length / 2) - 1;
            string middleChars = text.Substring(index, 2);
            return middleChars;
        }
    }
}
