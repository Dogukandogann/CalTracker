using Entities.Abstract;
using Entities.Enums;

namespace Entities.Concrete
{
    public class UserMeal : BaseEntity, IEntity
    {
        public DateTime MealDate { get; set; } = DateTime.Now;
        public MealTimes MealTime { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }

        public ICollection<FoodAmount> FoodAmounts { get; set; }
    }
}
