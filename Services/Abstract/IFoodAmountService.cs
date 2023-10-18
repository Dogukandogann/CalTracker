using Entities.Dtos;

namespace Services.Abstract
{
    public interface IFoodAmountService
    {
        void AddRangeMealItems(IEnumerable<MealItemDto> mealItems, int userMealId);
        void RemoveRangeMealItems(IEnumerable<MealItemDto> mealItems, int userMealId);
    }
}