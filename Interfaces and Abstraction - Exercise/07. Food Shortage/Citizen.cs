namespace P7.FoodShortage
{
    public class Citizen : IBirthdatale, IBuyer
    {
        public string Name { get; private set; }

        public int Age { get; private set; }
        public string Id { get; protected set; }
        public string BirthDate { get; private set; }
        public int Food { get; protected set; }

        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Citizen(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthDate;
            this.Food = 0;

        }

        public virtual void BuyFood()
        {
            this.Food += 10;
        }
    }
}
