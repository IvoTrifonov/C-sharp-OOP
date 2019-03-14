namespace P7.FoodShortage
{
    public class BuyerFactury
    {
        public Citizen Create(string[] buyerArgs)
        {
            var name = buyerArgs[0];
            var age = int.Parse(buyerArgs[1]);

            if (buyerArgs.Length == 4)
            {
                var id = buyerArgs[2];
                var birthDate = buyerArgs[3];
                var citizen = new Citizen(name, age, id, birthDate);
                return citizen;
            }
            else
            {
                var group = buyerArgs[2];
                var rebel = new Rebel(name, age, group);
                return rebel;
            }
        }
    }
}