using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> submissionsList = new Dictionary<string, Dictionary<string, int>>();
            string winner = string.Empty;
            int maxPoints = 0;
            string[] coursesInput = Console.ReadLine().Split(":");

            while (coursesInput[0] != "end of contests")
            {
                string courseName = coursesInput[0];
                string coursePassword = coursesInput[1];
                contests.Add(courseName, coursePassword);
                coursesInput = Console.ReadLine().Split(":");
            }
            string[] submissions = Console.ReadLine().Split("=>");
            while (submissions[0] != "end of submissions")
            {
                string course = submissions[0];
                string password = submissions[1];
                string user = submissions[2];
                int points = int.Parse(submissions[3]);

                if (contests.ContainsKey(course) && contests[course] == password)
                {
                    if (!submissionsList.ContainsKey(user))
                    {
                        submissionsList.Add(user, new Dictionary<string, int>());
                        submissionsList[user].Add(course, points);
                    }
                    else if (submissionsList.ContainsKey(user) && !submissionsList[user].ContainsKey(course))
                    {
                        submissionsList[user].Add(course, points);
                    }
                    else if (submissionsList.ContainsKey(user) && submissionsList[user].ContainsKey(course))
                    {
                        if (submissionsList[user][course] < points)
                        {
                            submissionsList[user][course] = points;
                        }
                    }
                }
                submissions = Console.ReadLine().Split("=>");
            }

            foreach (var item in submissionsList)
            {
                string name = item.Key;
                int currentPoints = 0;
                foreach (var point in item.Value)
                {
                    currentPoints += point.Value;
                }
                if (currentPoints > maxPoints)
                {
                    winner = name;
                    maxPoints = currentPoints;
                }
            }
            Console.WriteLine($"Best candidate is {winner} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var student in submissionsList.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);
                foreach (var contest in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
