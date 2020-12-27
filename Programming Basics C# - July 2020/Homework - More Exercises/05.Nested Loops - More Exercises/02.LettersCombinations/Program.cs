using System;

namespace _02.LettersCombinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char finishLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());
            int counter = 0;

            for (char b = startLetter; b <= finishLetter; b++)
            {
                for (char c = startLetter; c <= finishLetter; c++)
                {
                    for (char a = startLetter; a <= finishLetter; a++)
                    {
                        if (b != skipLetter && c != skipLetter && a != skipLetter)
                        {
                            counter++;
                            Console.Write($"{b}{c}{a} ");
                        }
                    }
                }
            }
            Console.WriteLine(+counter);
        }
    }
}
