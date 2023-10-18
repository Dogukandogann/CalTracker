using Entities.Abstract;

namespace Entities.Concrete
{
    public class FoodAmount : IEntity
    {
        public int FoodId { get; set; }
        public int Gram { get; set; }

        public Food Food { get; set; }

        public int UserMealId { get; set; }
        public UserMeal UserMeal { get; set; }
    }
}
