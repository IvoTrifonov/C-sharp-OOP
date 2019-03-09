namespace P6.Animals
{
    class Dog : Animal
    {
        private const string dogSound = "Woof!";

        public Dog(string name, int age, string gender)
            :base(name,age,gender)
        {

        }

        public override string ProduceSound()
        {
            return dogSound;
        }
    }
}
