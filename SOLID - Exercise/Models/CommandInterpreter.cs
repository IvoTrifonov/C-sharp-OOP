using ExerciseSOLID.Enums;
using ExerciseSOLID.Factory;
using ExerciseSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Models
{
    class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;

        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactury();
        }

        public void AddAppender(string[] args)
        {
            var typeAppender = args[0];
            var typeLayout = args[1];
            ReportLevel reportLevel = ReportLevel.INFO;

            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]);
            }

            ILayout layout = this.layoutFactory.CreateLayout(typeLayout);
            IAppender appender = this.appenderFactory.CreateAppender(typeAppender, layout);

            appender.ReportLevel = reportLevel;
            appenders.Add(appender);
        }

        public void AddReport(string[] args)
        {
            var dateTime = args[1];
            var message = args[2];
            ReportLevel reportLevel = Enum.Parse<ReportLevel>(args[0]);

            foreach (var appender in appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info");

            foreach (var appender in appenders)
            {
                Console.WriteLine(appender.ToString());
            }
        }
    }
}
