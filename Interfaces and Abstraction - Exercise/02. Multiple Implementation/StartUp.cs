using System;
using System.Collections.Generic;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();

            var identifiable = new Citizen(name, age, id, birthdate);
            var birthable = new Citizen(name, age, id, birthdate);

            Console.WriteLine(identifiable.Id);
            Console.WriteLine(birthable.Birthdate);
        }
    }
}
