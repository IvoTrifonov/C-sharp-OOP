namespace P1.BorderControl
{
    public class Robot : Creature
    {
        public string Model { get; private set; }
        public override string Id { get; protected set; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
