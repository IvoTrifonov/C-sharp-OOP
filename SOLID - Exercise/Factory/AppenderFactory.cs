using System;
using System.Collections.Generic;
using System.Text;
using ExerciseSOLID.Interfaces;
using ExerciseSOLID.Models;

namespace ExerciseSOLID.Factory
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            switch (type.ToLower())
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}
