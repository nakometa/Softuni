using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int target = 10000;
            int totalSteps = 0;

            while (totalSteps < target)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    int stepsWhileGoingHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsWhileGoingHome;
                    break;
                }
                else
                {
                    int steps = int.Parse(input);
                    totalSteps += steps;
                }
            }
            if (totalSteps >= target)
            {
                int stepsOverTarget = totalSteps - target;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsOverTarget} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
