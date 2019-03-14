using P8.MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P8.MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {

            var soldiers = new List<Soldier>();

            var command = Console.ReadLine();

            while (command != "End")
            {
                var splittedArgs = command.Split();
                var typeOfSoldier = splittedArgs[0];

                var id = splittedArgs[1];
                var firstName = splittedArgs[2];
                var lastName = splittedArgs[3];

                if (typeOfSoldier == "Private")
                {
                    decimal salary = decimal.Parse(splittedArgs[4]);
                    var privateSoldier = new Private(id, firstName, lastName, salary);

                    soldiers.Add(privateSoldier);
                }
                else if (typeOfSoldier == "Spy")
                {
                    int codeNumbr = int.Parse(splittedArgs[4]);
                    var spy = new Spy(id, firstName, lastName, codeNumbr);

                    soldiers.Add(spy);
                }
                else if (typeOfSoldier == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(splittedArgs[4]);
                    var ids = splittedArgs.Skip(5).ToList();
                    var privates = GetPrivates(ids, soldiers);
                    var lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary, privates);

                    soldiers.Add(lieutenantGeneral);
                }
                else if (typeOfSoldier == "Engineer")
                {
                    decimal salary = decimal.Parse(splittedArgs[4]);
                    string corps = splittedArgs[5];

                    var repairArgs = splittedArgs.Skip(6).ToList();
                    var repairs = GetRepairs(repairArgs);

                    try
                    {
                        var engineer = new Engineer(id, firstName, lastName, salary, corps, repairs);
                        soldiers.Add(engineer);
                    }
                    catch (Exception)
                    {
                    }
                }
                else if (typeOfSoldier == "Commando")
                {
                    decimal salary = decimal.Parse(splittedArgs[4]);
                    string corps = splittedArgs[5];

                    var missionArgs = splittedArgs.Skip(6).ToList();
                    var missions = GetMissions(missionArgs);

                    try
                    {
                        var comando = new Commando(id, firstName, lastName, salary, corps, missions);
                        soldiers.Add(comando);
                    }
                    catch (Exception)
                    {
                    }

                }

                command = Console.ReadLine();

            }

            foreach (var item in soldiers)
            {
                Console.WriteLine(item);
            }
        }

        private static List<Mission> GetMissions(List<string> missionArgs)
        {
            var missions = new List<Mission>();

            for (int i = 0; i < missionArgs.Count; i += 2)
            {
                var codeName = missionArgs[i];
                var state = missionArgs[i + 1];

                try
                {
                    missions.Add(new Mission(codeName, state));
                }
                catch (Exception)
                {
                }

            }

            return missions;
        }

        private static List<Repair> GetRepairs(List<string> repairArgs)
        {
            var repairs = new List<Repair>();

            for (int i = 0; i < repairArgs.Count; i += 2)
            {
                repairs.Add(new Repair(repairArgs[i], int.Parse(repairArgs[i + 1])));
            }

            return repairs;
        }

        private static List<Private> GetPrivates(List<string> ids, List<Soldier> soldiers)
        {
            var privates = new List<Private>();

            foreach (var id in ids)
            {
                var currentPrivate = (Private)soldiers.Where(x => x.Id == id).FirstOrDefault();
                privates.Add(currentPrivate);
            }

            return privates;
        }


    }
}
