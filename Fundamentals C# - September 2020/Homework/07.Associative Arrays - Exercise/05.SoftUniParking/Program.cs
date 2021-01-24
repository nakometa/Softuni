using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> database = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                string username = input[1];

                if (command == "register")
                {
                    string carPlate = input[2];
                    if (!database.ContainsKey(username))
                    {
                        database.Add(username, carPlate);
                        Console.WriteLine($"{username} registered {carPlate} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {database[username]}");
                    }
                }
                else
                {
                    if (!database.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        database.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var user in database)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
