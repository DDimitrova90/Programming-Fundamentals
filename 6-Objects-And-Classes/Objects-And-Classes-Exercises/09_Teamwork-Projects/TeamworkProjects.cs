using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main()
        {
            int teamCount = int.Parse(Console.ReadLine());

            // create teams
            List<Team> teams = CreateTeams(teamCount);

            // users join teams
            HandleJoinTeams(teams);


            // Filter the empty teams in a list
            List<Team> emptyTeams = teams
                .Where(x => x.Members.Count == 0)
                .Select(team => team)
                .OrderBy(team => team.Name)
                .ToList();

            // remove empty teams
            teams = teams.Except(emptyTeams).ToList();

            // print results
            var orderedValidTeams = teams
                .OrderByDescending(team => team.Members.Count)
                .ThenBy(team => team.Name);

            foreach (Team team in orderedValidTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                // print members sorted
                team.Members = team.Members.OrderBy(x => x).ToList();

                foreach (var teamMember in team.Members)
                {
                    Console.WriteLine($"-- {teamMember}");
                }
            }

            // print disbanded teams
            Console.WriteLine("Teams to disband:");

            foreach (var team in emptyTeams)
            {
                Console.WriteLine(team.Name);
            }
        }

        static List<Team> CreateTeams(int teamCount)
        {
            // create a list of Team objects
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] info = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string user = info[0];
                string team = info[1];

                if (teams.Select(x => x.Name).Contains(team))  // trying to create an existing team again
                {
                    Console.WriteLine($"Team {team} was already created!");
                    continue;
                }
                if (teams.Select(x => x.Creator).Contains(user))  // creator trying to create another team
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }

                Console.WriteLine($"Team {team} has been created by {user}!");
                teams.Add(new Team(user, team));
            }

            return teams;
        }

        static void HandleJoinTeams(List<Team> teams)
        {
            // this method handles all the commands for users that want to join certain teams
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of assignment")
                    break;

                string[] separatedInput = command.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string user = separatedInput[0];
                string teamToJoin = separatedInput[1];

                if (!teams.Select(team => team.Name).Contains(teamToJoin))  // trying to join a team that doesn't exist
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                    continue;
                }
                if (teams.Select(team => team.Members.Contains(user)).Contains(true) ||  // the user is in another team
                    teams.Select(team => team.Creator).Contains(user))    // the user is a creater of a team
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                    continue;
                }

                // add the user to the team
                teams.Where(team => team.Name == teamToJoin).First().AddMember(user);
            }
        }
    }

    class Team
    {
        public string Name { get; }
        public string Creator { get; }
        public List<string> Members { get; set; }

        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.Members = new List<string>();
            this.Name = teamName;
        }

        public void AddMember(string member)
        {
            Members.Add(member);
        }
    }
}
