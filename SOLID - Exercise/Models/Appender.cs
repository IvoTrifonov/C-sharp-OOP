using ExerciseSOLID.Enums;
using ExerciseSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseSOLID.Models
{
    public abstract class Appender : IAppender
    {
        private ILayout layout;

        protected Appender(ILayout layout)
        {
            this.layout = layout;
            this.MessagesCount = 0;
        }

        protected ILayout Layout => this.layout;

        public ReportLevel ReportLevel { get; set; }

        public int MessagesCount { get; set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessagesCount}";
        }
    }
}
