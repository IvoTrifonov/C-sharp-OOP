using System;
using System.Collections.Generic;
using System.Linq;

namespace P1.BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var creatures = new List<ICreature>();
            var creatureFactory = new CreatureFactory();
            var command = Console.ReadLine();

            while (command != "End")
            {
                var creatureTokens = command.Split();
                var creature = creatureFactory.Add(creatureTokens);
                creatures.Add(creature);

                command = Console.ReadLine();
            }

            var fakeIdNumber = Console.ReadLine();

            foreach (var creature in creatures.Where(c => c.Id.EndsWith(fakeIdNumber)))
            {
                Console.WriteLine(creature.Id);
            }
        }
    }
}
