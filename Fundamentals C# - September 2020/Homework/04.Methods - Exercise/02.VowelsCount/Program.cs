using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int result = VowelsCount(input);
            Console.WriteLine(result);
        }

        private static int VowelsCount(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];

                if (currentChar == 'a' || currentChar == 'e' ||
                    currentChar == 'i' || currentChar == 'o' ||
                    currentChar == 'u' || currentChar == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
