namespace P6.Animals
{
    class Kitten : Cat
    {
        private const string KittenSound = "Meow";
        private const string Gender = "Female";

        public Kitten(string name, int age)
            : base(name, age, Gender)
        {
            
        }

        public override string ProduceSound()
        {
            return KittenSound;
        }
    }
}
