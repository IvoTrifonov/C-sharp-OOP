using P8.MilitaryElite.Models;
using System.Collections.Generic;

namespace P8.MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<Private> Privates { get; }
    }
}
