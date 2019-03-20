
using ExerciseSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Models
{
    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            int appendersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appendersCount; i++)
            {
                var appenderArgs = Console.ReadLine().Split();

                this.commandInterpreter.AddAppender(appenderArgs);
            }

            var command = Console.ReadLine();

            while (command != "END")
            {
                var reportArgs = command.Split("|");
                commandInterpreter.AddReport(reportArgs);

                command = Console.ReadLine();
            }

            commandInterpreter.PrintInfo(); 
        }
    }
}
