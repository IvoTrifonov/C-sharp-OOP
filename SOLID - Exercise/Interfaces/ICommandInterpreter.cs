namespace ExerciseSOLID.Interfaces
{
    public interface ICommandInterpreter
    {
        void AddAppender(string[] args);

        void AddReport(string[] args);

        void PrintInfo();
    }
}
