using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            int currentNum = 0;
            int num = 0;
            bool valid = false;
            for (int i = 1; i <= limit; i++)
            {
                num = i;
                while (i > 0)
                {
                    currentNum += i % 10;
                    i = i / 10;
                }
                valid = (currentNum == 5) || (currentNum == 7) || (currentNum == 11);
                Console.WriteLine("{0} -> {1}", num, valid);
                currentNum = 0;
                i = num;
            }
        }
    }
}
