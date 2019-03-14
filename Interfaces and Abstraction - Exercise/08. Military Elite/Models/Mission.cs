using P8.MilitaryElite.Interfaces;
using System;

namespace P8.MilitaryElite.Models
{
    public class Mission : IMission
    {
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public void CompleteMission()
        {
            this.state = "Finished";
        }

        public string CodeName { get; private set; }

        public string State
        {
            get => this.state;

            private set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException("Invalid state!");
                }

                this.state = value;
            }
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.state}";
        }
    }
}
