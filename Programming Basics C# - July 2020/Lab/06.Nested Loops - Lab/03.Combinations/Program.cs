using System;

namespace _03.Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int a = 0; a <= magicNumber; a++)
            {
                for (int b = 0; b <= magicNumber; b++)
                {
                    for (int c = 0; c <= magicNumber; c++)
                    {
                        if (a + b + c == magicNumber)
                        {
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
