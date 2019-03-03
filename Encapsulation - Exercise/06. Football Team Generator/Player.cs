using System;
using System.Collections.Generic;
using System.Text;

namespace P6.FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private Dictionary<string, int> stats;

        public Player(string name, int[] stats)
        {
            this.Name = name;
            this.Stats = AddStats(stats);
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public Dictionary<string, int> Stats
        {
            get => this.stats;

            private set
            {
                foreach (var stat in value)
                {
                    if (stat.Value < 0 || stat.Value > 100)
                    {
                        throw new ArgumentException($"{stat.Key} should be between 0 and 100.");
                    }
                }

                this.stats = value;
            }
        }

        private Dictionary<string, int> AddStats(int[] stats)
        {
            this.stats = new Dictionary<string, int>();

            this.stats.Add("Endurance", stats[0]);
            this.stats.Add("Sprint", stats[1]);
            this.stats.Add("Dribble", stats[2]);
            this.stats.Add("Passing", stats[3]);
            this.stats.Add("Shooting", stats[4]);

            return this.stats;
        }

    }
}
