using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P1.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var creatures = new List<IBirthdatale>();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var creatureArgs = command.Split();
                var type = creatureArgs[0];

                if (type == "Citizen")
                {
                    var name = creatureArgs[1];
                    var age = int.Parse(creatureArgs[2]);
                    var id = creatureArgs[3];
                    var birthdate = creatureArgs[4];
                    var citizen = new Citizen(name, age, id, birthdate);
                    creatures.Add(citizen);
                }
                else if (type == "Pet")
                {
                    var name = creatureArgs[1];
                    var birthdate = creatureArgs[2];
                    var pet = new Pet(name, birthdate);
                    creatures.Add(pet);
                }
                command = Console.ReadLine();
            }

            var year = Console.ReadLine();

            foreach (var creature in creatures.Where(c => c.BirthDate.EndsWith(year)))
            {
                Console.WriteLine(creature.BirthDate);
            }

        }
    }
}
