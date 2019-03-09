namespace P6.Animals
{
    public class Tomcat : Cat
    {
        private const string kittenSound = "MEOW";
        private const string Gender = "Male";

        public Tomcat(string name, int age)
            : base(name, age, Gender)
        {
            
        }

        public override string ProduceSound()
        {
            return kittenSound;
        }
    }
}
