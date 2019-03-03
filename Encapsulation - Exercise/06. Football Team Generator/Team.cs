using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P6.FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.name = name;
            this.Players = new List<Player>();
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

        public List<Player> Players { get; set; }
    }
}
