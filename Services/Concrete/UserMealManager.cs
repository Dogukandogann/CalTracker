using Entities.Concrete;
using Entities.Dtos;
using Entities.Enums;
using FluentEmail.Core;
using Repositories.Abstract;
using Repositories.Concrete.EFCore;
using Services.Abstract;

namespace Services.Concrete
{
    public partial class UserMealManager : IUserMealService
    {
        private readonly IUserMealRepository _userMealRepository = new UserMealRepository();
        private readonly IUserRepository _userRepository = new UserRepository();

        public IEnumerable<FoodNutrionals> GetUserMeals(int userId, DateTime mealDate, MealTimes mealTime)
        {
            var userMeals = _userMealRepository.GetUserMealByUserIdAndMealDateAndMealTime(userId, mealDate, mealTime);

            if (userMeals is null)
                return new List<FoodNutrionals>();

            var nutrionals = CalculateNutrionals(userMeals.FoodAmounts);
            var foodList = new List<FoodNutrionals>();
            userMeals.FoodAmounts.ForEach(fa =>
            {
                foodList.Add(new FoodNutrionals
                {
                    FoodName = fa.Food.Name,
                    Gram = fa.Gram,
                    Calorie = nutrionals.Calorie,
                    Carbonhidrate = nutrionals.Carbonhidrate,
                    Fat = nutrionals.Fat,
                    Protein = nutrionals.Protein


                });
            });

            return foodList;
        }

        public int CreateUserMeal(int userId, MealTimes mealTime, DateTime date)
        {
            if (CheckIfUserMealUserMealExists(userId, mealTime, date))
                return _userMealRepository.GetUserMealIdByUserIdAndMealDateAndMealTime(userId, date, mealTime);

            var userMeal = new UserMeal { UserId = userId, MealDate = date, MealTime = mealTime };

            _userMealRepository.Create(userMeal);

            return userMeal.Id;

        }

        public IEnumerable<MealNutrionals> GetUserMealsByUserIdAndMealDate(int userId, DateTime mealDate)
        {
            var userMeals = _userMealRepository.GetUserMealsByUserIdAndMealDate(userId, mealDate).ToList();

            return CalculateMealNutrionalsByCategoryId(userMeals);

        }

        public PeriodicCalories GetUserNutrionalsByUserIdAndDateRange(int userId, DateTime startDate, DateTime endDate, int categoryId = 0)
        {
            var userMeals = _userMealRepository.GetUserMealsByUserIdAndDateRange(userId, startDate, endDate).ToList();

            return CalculateNutrionals(userMeals, categoryId);

        }

        public IEnumerable<MostConsumed> GetMostConsumed()

            => _userMealRepository.GetMostConsumed();

        public PeriodicCalories GetUserNutrionalsAllByDateRange(DateTime startDate, DateTime endDate, int categoryId = 0)
        {
            var userMeals = _userMealRepository.GetUserMealsAllByDateRange(startDate, endDate).ToList();

            var pC = CalculateNutrionals(userMeals, categoryId);    // Periodic Calories

            var activeUserCount = _userRepository.GetActiveUserCount();


            pC.Breakfast = Math.Round(pC.Breakfast / activeUserCount, 2);
            pC.Lunch = Math.Round(pC.Lunch / activeUserCount, 2);
            pC.Dinner = Math.Round(pC.Dinner / activeUserCount, 2);
            pC.Snack = Math.Round(pC.Snack / activeUserCount, 2);

            return pC;

        }

        public IEnumerable<FoodConsumption> GetFoodConsumptionForAllTimes()

            => _userMealRepository.GetFoodConsumptionForAllTimes();

        private PeriodicCalories CalculateNutrionals(IEnumerable<UserMeal> mealNutrionals, int categoryId = 0)
        {
            var periodicNutrionals = new PeriodicCalories();
            var nutrionals = CalculateMealNutrionalsByCategoryId(mealNutrionals, categoryId);

            foreach (MealTimes mealTime in Enum.GetValues(typeof(MealTimes)))
            {
                var totalCalorie = nutrionals.Where(mn => mn.MealTime == mealTime).Sum(mn => mn.Calorie);
                typeof(PeriodicCalories).GetProperty(mealTime.ToString()).SetValue(periodicNutrionals, totalCalorie);
            }

            periodicNutrionals.CategoryId = categoryId;
            return periodicNutrionals;
        }

        private List<MealNutrionals> CalculateMealNutrionalsByCategoryId(IEnumerable<UserMeal> userMeals, int categoryId = 0)
        {
            var mealNutrionalsList = new List<MealNutrionals>();

            if (!userMeals.SelectMany(um => um.FoodAmounts).Any())
                return mealNutrionalsList;

            if (!categoryId.Equals(0))
            {
                userMeals = userMeals.Select(um => new UserMeal
                {
                    FoodAmounts = um.FoodAmounts.Where(fa => fa.Food.FoodCategoryId.Equals(categoryId)).ToList(),
                    Id = um.Id,
                    MealDate = um.MealDate,
                    MealTime = um.MealTime,
                    User = um.User,
                    UserId = um.UserId

                });
            }

            foreach (MealTimes mealTime in Enum.GetValues(typeof(MealTimes))) // iterate meal times
            {
                var meals = userMeals.Where(um => um.MealTime == mealTime);

                if (meals.Any()) // if there is no meal in the meal time then, no need to calculate.
                {
                    var nutrionals = CalculateNutrionals(meals.SelectMany(um => um.FoodAmounts));

                    var mealNutrionals = new MealNutrionals
                    {
                        MealTime = mealTime,
                        Calorie = nutrionals.Calorie,
                        Carbonhidrate = nutrionals.Carbonhidrate,
                        Fat = nutrionals.Fat,
                        Protein = nutrionals.Protein,
                    };


                    mealNutrionalsList.Add(mealNutrionals);
                }
            }
            return mealNutrionalsList;
        }
        private Nutrionals CalculateNutrionals(IEnumerable<FoodAmount> foodAmounts)
        {
            double totalCalorie = 0, totalCarbonhidrate = 0, totalFat = 0, totalProtein = 0;

            foodAmounts.ForEach(fa =>
            {
                var food = fa.Food;
                var gram = fa.Gram;

                totalCalorie += (food.Calorie / food.Gram) * gram;
                totalCarbonhidrate += (food.Carbonhidrate / food.Gram) * gram;
                totalFat += (food.Fat / food.Gram) * gram;
                totalProtein += (food.Protein / food.Gram) * gram;
            });

            return new Nutrionals
            {
                Calorie = Math.Round(totalCalorie, 2),
                Carbonhidrate = Math.Round(totalCarbonhidrate, 2),
                Fat = Math.Round(totalFat, 2),
                Protein = Math.Round(totalProtein, 2)
            };
        }

        private bool CheckIfUserMealUserMealExists(int userId, MealTimes mealTime, DateTime mealDate)

         => _userMealRepository.Any(
                um => um.UserId.Equals(userId)
                && um.MealDate.Date.Equals(mealDate.Date)
                && um.MealTime == mealTime);

    }
}



