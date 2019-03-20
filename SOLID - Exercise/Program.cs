namespace ExerciseSOLID
{
    using ExerciseSOLID.Interfaces;
    using ExerciseSOLID.Models;

    public class Program
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            var engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
