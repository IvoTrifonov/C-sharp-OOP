using System;
using System.Globalization;

namespace P1.BorderControl
{
    public class Citizen : Creature, IBirthdatale
    {
        public string Name { get; private set; }

        public int Age { get; private set; }
        public override string Id { get; protected set; }
        public string BirthDate { get; private set; }

        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
            
        }
    }
}
