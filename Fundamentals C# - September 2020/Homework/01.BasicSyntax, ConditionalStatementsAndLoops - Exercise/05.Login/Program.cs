using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var counter = 0;
            var password = string.Empty;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                var currentLetter = username[i];
                password += currentLetter;
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input != password)
                {
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}
