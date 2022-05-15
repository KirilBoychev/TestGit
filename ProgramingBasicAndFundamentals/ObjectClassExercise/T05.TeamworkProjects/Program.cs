using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();

            for (int everyTeam = 0; everyTeam < countOfTeams; everyTeam++)
            {
                string[] arrTeams = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string creatorName = arrTeams[0];
                string teamName = arrTeams[1];

                if (teams.Any(t => t.Team == teamName))
                {
                    //there is duplicate team
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(c => c.Creator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                
                Teams currTeam = new Teams(creatorName, teamName);
                teams.Add(currTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }

            string joinTeam = String.Empty;

            while ((joinTeam = Console.ReadLine()) != "end of assignment")
            {
                string[] arrMembers = joinTeam
                     .Split("->", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();

                string currentMember = arrMembers[0];
                string currentTeam = arrMembers[1];

                Teams searchTeam = teams.FirstOrDefault(x => x.Team == currentTeam);
                if (searchTeam == null)
                {
                    Console.WriteLine($"Team {currentTeam} does not exist!");
                    continue;
                }

                if (teams.Any(x => x.Members.Contains(currentMember)) || teams.Any(x => x.Creator.Contains(currentMember)))
                {
                    Console.WriteLine($"Member {currentMember} cannot join team {currentTeam}!");
                    continue;
                }

                //if (teams.Any(c => c.Team != currentTeam))
                //{
                //    Console.WriteLine($"Team {currentTeam} does not exist!");
                //    Console.WriteLine($"Member {currentMember} cannot join team {currentTeam}!");;
                //}
                //if (teams.Any(c => c.Creator == currentMember))
                //{
                //    Console.WriteLine($"Member {currentMember} cannot join team {currentTeam}!");
                //    continue;
                //}

                searchTeam.Members.Add(currentMember);
            }

            List<Teams> withMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(o => o.Team)
                .ToList();
            List<Teams> noMemberss = teams
                .Where(y => y.Members.Count == 0)
                .OrderBy(x => x.Team)
                .ToList();

            foreach  (Teams validTeam in withMembers)
            {
                Console.WriteLine($"{validTeam.Team}");
                Console.WriteLine($"- {validTeam.Creator}");
                foreach (var ordered in validTeam.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {ordered}");

                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (Teams invalidTeam in noMemberss)
            {
                Console.WriteLine($"{invalidTeam.Team}");
            }
        }
    }
    class Teams
    {
        public Teams(string creator, string team)
        {
            this.Creator = creator;
            this.Team = team;
            this.Members = new List<string>();
        }
        public string Creator { get; set; }

        public string Team { get; set; }

        public List<string> Members { get; set; }
        //public void AddMember(string member)
        //{
        //    this.Members.Add(member);
        //}
    }
}
