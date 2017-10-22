using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Teamwork_Projects
{
    class Team
    {
        public string NameTeam { get; set; }
        public string NameCreator { get; set; }
        public List<string> TeamMembers { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] nameAndTeamToCreate = Console.ReadLine().Split(new char[] { '-' }, StringSplitOptions.None);
                bool createTeam = true;
                foreach (var item in teams)
                {
                    if (item.NameTeam.Contains(nameAndTeamToCreate[1]))
                    {
                        Console.WriteLine($"Team {nameAndTeamToCreate[1]} was already created!");
                        createTeam = false;
                        break;
                    }
                    else if (item.NameCreator.Contains(nameAndTeamToCreate[0]))
                    {
                        Console.WriteLine($"{nameAndTeamToCreate[0]} cannot create another team!");
                        createTeam = false;
                        break;
                    }
                }
                if (createTeam)
                {
                    Team team = new Team();
                    team.TeamMembers = new List<string>();
                    team.NameTeam = nameAndTeamToCreate[1];
                    team.NameCreator = nameAndTeamToCreate[0];
                    teams.Add(team);
                    Console.WriteLine($"Team {nameAndTeamToCreate[1]} has been created by {nameAndTeamToCreate[0]}!");
                }
            }

            string assignment = Console.ReadLine();
            while (assignment != "end of assignment")
            {
                string[] assignmentNameAndTeam = assignment.Split(new[] { "->" }, StringSplitOptions.None);

                bool isInTeam = false;
                bool isExistTeam = false;

                foreach (var item in teams)
                {
                    if (item.NameTeam.Equals(assignmentNameAndTeam[1]))
                    {
                        isExistTeam = true;
                    }
                    if (item.NameCreator.Equals(assignmentNameAndTeam[0]) || item.TeamMembers.Contains(assignmentNameAndTeam[0]))
                    {
                        isInTeam = true;
                    }
                }

                if (!isExistTeam)
                {
                    Console.WriteLine($"Team {assignmentNameAndTeam[1]} does not exist!");
                }
                else if (isInTeam)
                {
                    Console.WriteLine($"Member {assignmentNameAndTeam[0]} cannot join team {assignmentNameAndTeam[1]}!");
                }
                else
                {
                    foreach (var item in teams)
                    {
                        if (item.NameTeam.Contains(assignmentNameAndTeam[1]))
                        {
                            item.TeamMembers.Add(assignmentNameAndTeam[0]);
                            break;
                        }
                    }
                }
                assignment = Console.ReadLine();
            }

            foreach (var item in teams.Where(x => x.TeamMembers.Count > 0).OrderByDescending(x => x.TeamMembers.Count)
                .ThenBy(x => x.NameTeam))
            {
                Console.WriteLine(item.NameTeam);
                Console.WriteLine($"- {item.NameCreator}");
                foreach (var members in item.TeamMembers.OrderBy(x => x))
                {
                    Console.Write(new string('-', 2));
                    Console.WriteLine($" {members}");
                }

            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teams.Where(x => x.TeamMembers.Count == 0).OrderBy(name => name.NameTeam))
            {
                Console.WriteLine(item.NameTeam);
            }
        }
    }
}
