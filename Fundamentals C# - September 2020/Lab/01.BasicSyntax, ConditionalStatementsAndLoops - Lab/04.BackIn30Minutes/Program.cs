using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeAfterThirtyMinutes = minutes + 30;

            if (timeAfterThirtyMinutes >= 60)
            {
                hours++;
                timeAfterThirtyMinutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            Console.WriteLine($"{hours}:{timeAfterThirtyMinutes:D2}");
        }
    }
}
