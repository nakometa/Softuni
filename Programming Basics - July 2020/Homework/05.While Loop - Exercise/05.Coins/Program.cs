using System;

namespace _05.Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            double convert = sum * 100;
            int pieces = (int)convert;
            double coins = 0;

            while (pieces > 0)
            {
                if (pieces - 200 >= 0)
                {
                    coins++;
                    pieces -= 200;
                }
                else if (pieces - 100 >= 0)
                {
                    coins++;
                    pieces -= 100;
                }
                else if (pieces - 50 >= 0)
                {
                    coins++;
                    pieces -= 50;
                }
                else if (pieces - 20 >= 0)
                {
                    coins++;
                    pieces -= 20;
                }
                else if (pieces - 10 >= 0)
                {
                    coins++;
                    pieces -= 10;
                }
                else if (pieces - 5 >= 0)
                {
                    coins++;
                    pieces -= 5;
                }
                else if (pieces - 2 >= 0)
                {
                    coins++;
                    pieces -= 2;
                }
                else if (pieces - 1 >= 0)
                {
                    coins++;
                    pieces -= 1;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
