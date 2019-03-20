using ExerciseSOLID.Enums;

namespace ExerciseSOLID.Interfaces
{
    public interface IAppender
    {
        int MessagesCount { get; }

        void Append(string dateTime, ReportLevel reportLevel, string message);

        ReportLevel ReportLevel { get; set; }
    }
}
