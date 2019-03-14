using P8.MilitaryElite.Models;
using System.Collections.Generic;

namespace P8.MilitaryElite.Interfaces
{
   public interface IEngineer
    {
        IReadOnlyCollection<Repair> Repairs { get; }
    }
}
