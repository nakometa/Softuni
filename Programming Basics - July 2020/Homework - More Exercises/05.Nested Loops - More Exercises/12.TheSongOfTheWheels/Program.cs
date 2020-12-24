using System;

namespace _12.TheSongOfTheWheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int counter = 0;
            string pass = "";
            bool isFound = true;

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            bool bBiggerThanA = false;
                            bool cBiggerThanD = false;
                            int sum = (a * b) + (c * d);
                            if (c > d)
                            {
                                cBiggerThanD = true;
                            }
                            if (b > a)
                            {
                                bBiggerThanA = true;
                            }
                            if (sum == m && bBiggerThanA && cBiggerThanD)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (counter == 4)
                                {
                                    pass = ($"{a}{b}{c}{d}");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (counter < 4)
            {
                isFound = false;
            }
            if (isFound)
            {
                Console.WriteLine($"Password: {pass}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
