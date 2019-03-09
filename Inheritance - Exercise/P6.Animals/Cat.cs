namespace P6.Animals
{
    public class Cat : Animal
    {
        private const string catSound = "Meow meow";

        public Cat(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        public override string ProduceSound()
        {
            return catSound;
        }
    }
}
