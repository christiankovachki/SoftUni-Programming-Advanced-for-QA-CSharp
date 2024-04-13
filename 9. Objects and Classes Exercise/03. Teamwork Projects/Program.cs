namespace _03._Teamwork_Projects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int countOfTeams = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOfTeams; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creator = teamInfo[0];
                string teamName = teamInfo[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(teamName, creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] inputData = input.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = inputData[0];
                string team = inputData[1];

                if (!teams.Any(t => t.Name == team))
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }

                if (teams.Any(t => t.Members.Contains(user) || t.Creator == user))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    input = Console.ReadLine();
                    continue;
                }
                
                teams.FirstOrDefault(t => t.Name == team).Members.Add(user);

                input = Console.ReadLine();
            }

            teams.Where(t => t.Members.Count > 0)
                 .OrderByDescending(t => t.Members.Count)
                 .ThenBy(t => t.Name)
                 .Select(t => 
                    { 
                        Console.WriteLine($"{t.Name}");
                        Console.WriteLine($"- {t.Creator}");

                        foreach (var member in t.Members.OrderBy(m => m))
                        {
                            Console.WriteLine($"-- {member}");
                        }

                        return 1;
                    })
                 .ToList();

            Console.WriteLine("Teams to disband:");
            teams.Where(t => t.Members.Count == 0)
                 .OrderBy(t => t.Name)
                 .Select(t => 
                    { 
                        Console.WriteLine(t.Name); 
                        
                        return 1; 
                    })
                 .ToList();
        }
    }
}