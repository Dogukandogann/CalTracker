using Entities.Enums;

namespace Repositories.Concrete.EFCore
{
    public record MostConsumed
    {
        public MealTimes MealTime { get; init; }
        public string FoodName { get; init; }
    }
}
