using P8.MilitaryElite.Interfaces;
using System.Text;

namespace P8.MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Code Number: {this.CodeNumber}");

            return sb.ToString().TrimEnd();
        }
    }
}
