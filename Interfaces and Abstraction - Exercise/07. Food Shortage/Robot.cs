namespace P7.FoodShortage
{
    public class Robot
    {
        public string Model { get; private set; }
        public string Id { get; protected set; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
