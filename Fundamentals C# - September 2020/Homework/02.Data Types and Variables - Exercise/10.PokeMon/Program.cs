using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong power = ulong.Parse(Console.ReadLine());
            uint distance = uint.Parse(Console.ReadLine());
            byte exhaustion = byte.Parse(Console.ReadLine());
            decimal halfPercent = power * 0.5M;
            var targets = 0;
            //
            while (power >= distance)
            {
                power -= distance;
                targets++;
                if (power == halfPercent && power > 0 && exhaustion > 0)
                {
                    power /= exhaustion;
                }
            }
            Console.WriteLine(power);
            Console.WriteLine(targets);
        }
    }
}
