using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-");
                string creator = teamInfo[0];
                string teamName = teamInfo[1];

                bool teamExists = teams.Select(x => x.TeamName).Contains(teamName);
                bool creatorExists = teams.Select(x => x.TeamCreator).Contains(creator);

                if (!teamExists)
                {
                    if (!creatorExists)
                    {
                        Team newTeam = new Team(teamName, creator);
                        teams.Add(newTeam);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string[] cmdArgs = Console.ReadLine().Split("->");
            while (cmdArgs[0] != "end of assignment")
            {
                string member = cmdArgs[0];
                string teamToJoin = cmdArgs[1];

                bool teamExists = teams.Select(x => x.TeamName).Contains(teamToJoin);
                bool isMemberOfTeam = teams.Select(x => x.Members).Any(x => x.Contains(member));
                bool isCreatorOfTeam = teams.Select(x => x.TeamCreator).Contains(member);

                if (teamExists)
                {
                    if (isCreatorOfTeam || isMemberOfTeam)
                    {
                        Console.WriteLine($"Member {member} cannot join team {teamToJoin}!");
                    }
                    else
                    {
                        int index = teams.FindIndex(x => x.TeamName == teamToJoin);
                        teams[index].Members.Add(member);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }

                cmdArgs = Console.ReadLine().Split("->");
            }
            List<Team> teamsToDisband = new List<Team>(teams.Where(x => x.Members.Count == 0).OrderBy(x => x.TeamName));
            List<Team> activeTeams = new List<Team>(
                teams.Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName));

            foreach (var team in activeTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.TeamCreator}");
                foreach (var player in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {player}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsToDisband)
            {
                Console.WriteLine(team.TeamName);
            }

        }
    }

    class Team
    {
        public Team(string teamName, string teamCreator)
        {
            TeamName = teamName;
            TeamCreator = teamCreator;
            Members = new List<string>();
        }

        public string TeamName { get; set; }

        public string TeamCreator { get; set; }

        public List<string> Members { get; set; }
    }
}
