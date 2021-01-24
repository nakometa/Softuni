using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            while (!input.Contains("exam finished"))
            {
                if (input.Contains("banned"))
                {
                    string[] commandArr = input.Split("-");
                    string bannedUser = commandArr[0];

                    users[bannedUser][1] = "banned";
                }
                else
                {
                    string[] commandArr = input.Split("-");
                    string user = commandArr[0];
                    string language = commandArr[1];
                    int score = int.Parse(commandArr[2]);

                    if (users.ContainsKey(user))
                    {
                        if (int.Parse(users[user][1]) < score)
                        {
                            users[user][1] = score.ToString();
                        }
                    }
                    else
                    {
                        users.Add(user, new List<string> { language, score.ToString() });
                    }
                    if (languages.ContainsKey(language))
                    {
                        languages[language]++;
                    }
                    else
                    {
                        languages.Add(language, 1);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var user in users.Where(x => x.Value[1] != "banned").OrderByDescending(x => x.Value[1]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value[1]}");
            }
            Console.WriteLine("Submissions:");
            foreach (var item in languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}