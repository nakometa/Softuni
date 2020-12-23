using System;

namespace _07.SafePasswordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPass = int.Parse(Console.ReadLine());
            int counter = 0;
            bool limitReached = false;

            int A = 35;
            int B = 64;

            for (int i = 1; i <= a; i++)
            {
                for (int p = 1; p <= b; p++)
                {
                    Console.Write($"{(char)A}{(char)B}{i}{p}{(char)B}{(char)A}|");
                    counter++;
                    if (counter == maxPass)
                    {
                        limitReached = true;
                        break;
                    }
                    A++;
                    B++;
                    if (A > 55)
                    {
                        A = 35;
                    }
                    if (B > 96)
                    {
                        B = 64;
                    }
                }
                if (limitReached)
                {
                    break;
                }
            }
        }
    }
}
