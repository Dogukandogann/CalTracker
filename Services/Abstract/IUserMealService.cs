using Entities.Concrete;
using Entities.Dtos;
using Entities.Enums;
using Repositories.Concrete.EFCore;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IUserMealService
    {
        IEnumerable<FoodNutrionals> GetUserMeals(int userId, DateTime mealDate, MealTimes mealTime);
        int CreateUserMeal(int userId, MealTimes mealTime, DateTime date);
        IEnumerable<MealNutrionals> GetUserMealsByUserIdAndMealDate(int userId, DateTime mealDate);
        PeriodicCalories GetUserNutrionalsByUserIdAndDateRange(int userId, DateTime startDate, DateTime endDate, int categoryId = 0);
        PeriodicCalories GetUserNutrionalsAllByDateRange(DateTime startDate, DateTime endDate, int categoryId = 0);
        IEnumerable<MostConsumed> GetMostConsumed();
        IEnumerable<FoodConsumption> GetFoodConsumptionForAllTimes();

    }
}
