using Entities.Enums;

namespace Repositories.Concrete.EFCore
{
    public record FoodConsumption
    {
        public string FoodName { get; init; }
        public MealTimes MealTime { get; init; }
        public int TimesConsumed { get; init; }
    }
}
