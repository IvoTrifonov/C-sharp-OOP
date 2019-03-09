using P5.Mordor_sCruelPlan.Foods;

namespace P5.Mordor_sCruelPlan
{
    public class FoodFactory
    {
        public Food GetFood(string food)
        {
            switch (food.ToLower())
            {
                case "apple":
                    return new Apple();
                case "cram":
                    return new Crum();
                case "honeycake":
                    return new HoneyCake();
                case "lembas":
                    return new Lembas();
                case "melon":
                    return new Melon();
                case "mushrooms":
                    return new Mushrooms();

                default:
                    return null;
            }
        }
    }
}
