using ExerciseSOLID.Enums;
using ExerciseSOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExerciseSOLID.Models
{
    public class FileAppender : Appender
    {
        const string path = @"..\..\..\log.txt";

        private ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                string content = string.Format(this.Layout.Format, dateTime, reportLevel, message)
                + Environment.NewLine;

                File.AppendAllText(path, content);
                this.MessagesCount++;
                this.logFile.Write(content);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, File size: {this.logFile.Size}";
        }
    }
}
