namespace P6.Animals
{
    public class Frog : Animal
    {
        private const string frogSound = "Ribbit";

        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        public override string ProduceSound()
        {
            return frogSound;
        }

    }
}
