namespace P1.BorderControl
{
    public class CreatureFactory
    {
        public ICreature Add(string[] creatureTokens)
        {
            if (creatureTokens.Length == 3)
            {
                var name = creatureTokens[0];
                var age = int.Parse(creatureTokens[1]);
                var id = creatureTokens[2];
                var citizen = new Citizen(name, age, id);
                return citizen;
            }
            else
            {
                var model = creatureTokens[0];
                var id = creatureTokens[1];
                var robot = new Robot(model, id);
                return robot;
            }
        }
    }
}