using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P6.FootballTeamGenerator
{
    public class League
    {
        public List<Team> Teams { get; set; }

        public League()
        {
            this.Teams = new List<Team>();
        }

        public void AddPlayer(Player player, string teamName)
        {
            var team = this.Teams.FirstOrDefault(x => x.Name == teamName);
            team.Players.Add(player);
        }

        public void RemovePlayer(string playerName, string teamName)
        {
            var team = this.Teams.FirstOrDefault(x => x.Name == teamName);
            var player = team.Players.FirstOrDefault(x => x.Name == playerName);

            if (player != null)
            {
                team.Players.Remove(team.Players.FirstOrDefault(x => x.Name == playerName));
            }
            else
            {
                throw new ArgumentException($"Player {playerName} is not in {teamName} team.");
            }
        }

        public double GetTeamStats(string teamName)
        {
            double average = 0;
            var team = this.Teams.FirstOrDefault(x => x.Name == teamName);

            if (team.Players.Any())
            {
                foreach (var player in team.Players)
                {
                    double sum = 0;

                    foreach (var stat in player.Stats)
                    {
                        sum += stat.Value;
                    }

                    average += sum /= 5;
                }

                average /= team.Players.Count;
            }

            return Math.Round(average);
        }
    }
}