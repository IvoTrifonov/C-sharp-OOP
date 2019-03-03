using System;
using System.Linq;
namespace P6.FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var league = new League();
            var command = Console.ReadLine();

            while (command != "END")
            {
                try
                {
                    var commandTokens = command.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    var typeOfCommand = commandTokens[0];
                    var teamName = commandTokens[1];

                    if (typeOfCommand == "Team")
                    {
                        league.Teams.Add(new Team(teamName));
                    }

                    var team = league.Teams.FirstOrDefault(x => x.Name == teamName);

                    if (team == null)
                    {
                        Console.WriteLine($"Team {teamName} does not exist.");
                    }
                    else
                    {
                        if (typeOfCommand == "Add")
                        {
                            var playerName = commandTokens[2];
                            var playerArgs = commandTokens.Skip(3).Select(int.Parse).ToArray();
                            var player = new Player(playerName, playerArgs);
                            league.AddPlayer(player, teamName);
                        }
                        else if (typeOfCommand == "Remove")
                        {
                            var playerName = commandTokens[2];
                            league.RemovePlayer(playerName, teamName);
                        }
                        else if (typeOfCommand == "Rating")
                        {
                            Console.WriteLine($"{teamName} - {league.GetTeamStats(teamName)}");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
