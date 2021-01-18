using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int source = int.Parse(Console.ReadLine());
            var gainedSpice = 0;
            var days = 0;

            while (source >= 100)
            {
                gainedSpice += source;
                source -= 10;
                days++;
                if (gainedSpice >= 26)
                {
                    gainedSpice -= 26;
                }
            }
            if (gainedSpice >= 26)
            {
                gainedSpice -= 26;
            }
            Console.WriteLine(days);
            Console.WriteLine(gainedSpice);
        }
    }
}
