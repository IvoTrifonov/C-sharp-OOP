using ExerciseSOLID.Interfaces;

namespace ExerciseSOLID.Models
{
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
