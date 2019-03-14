using System.Collections.Generic;
using System.Text;
using P8.MilitaryElite.Interfaces;

namespace P8.MilitaryElite.Models
{
    class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, List<Private> privates)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public IReadOnlyCollection<Private> Privates { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Privates:");
            
            foreach (var item in this.Privates)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
