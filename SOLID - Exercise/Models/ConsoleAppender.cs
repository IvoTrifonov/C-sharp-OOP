using ExerciseSOLID.Enums;
using ExerciseSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Models
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
             : base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                Console.WriteLine(string.Format(base.Layout.Format, dateTime, reportLevel, message));
                this.MessagesCount++;
            }
        }
    }
}
