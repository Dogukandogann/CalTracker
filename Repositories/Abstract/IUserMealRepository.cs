using Entities.Concrete;
using Entities.Enums;
using Repositories.Abstract.Base;
using Repositories.Concrete.EFCore;

namespace Repositories.Abstract
{
    public interface IUserMealRepository : IBaseRepository<UserMeal>
    {
        UserMeal GetUserMealByUserIdAndMealDateAndMealTime(int userId, DateTime mealDate, MealTimes mealTime);
        int GetUserMealIdByUserIdAndMealDateAndMealTime(int userId, DateTime mealDate, MealTimes mealTime);
        IEnumerable<UserMeal> GetUserMealsByUserIdAndMealDate(int userId, DateTime mealDate);
        IEnumerable<UserMeal> GetUserMealsByUserIdAndDateRange(int userId, DateTime startDate, DateTime endDate);
        IEnumerable<UserMeal> GetUserMealsAllByDateRange(DateTime startDate, DateTime endDate);
        IEnumerable<MostConsumed> GetMostConsumed();
        IEnumerable<FoodConsumption> GetFoodConsumptionForAllTimes();
    }
}
