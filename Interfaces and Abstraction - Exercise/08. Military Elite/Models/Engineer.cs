using P8.MilitaryElite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace P8.MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, List<Repair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public IReadOnlyCollection<Repair> Repairs { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine($"Repairs:");
            foreach (var repair in this.Repairs)
            {
                sb.AppendLine($"  {repair.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
