using System.Collections.Generic;
using System.Text;
using P8.MilitaryElite.Interfaces;

namespace P8.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public IReadOnlyCollection<Mission> Missions { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine($"Missions:");
            foreach (var mission in this.Missions)
            {
                sb.AppendLine($"  {mission.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
