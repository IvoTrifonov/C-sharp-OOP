using P8.MilitaryElite.Interfaces;
using System;

namespace P8.MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => this.corps;

            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Invalid corps!");
                }

                this.corps = value;
            }
        }

    }
}
