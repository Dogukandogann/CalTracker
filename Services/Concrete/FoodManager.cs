using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Concrete.EFCore;
using Services.Abstract;

namespace Services.Concrete
{
    public class FoodManager : IFoodService
    {
        IFoodRepository _foodRepository = new FoodRepository();

        public IEnumerable<string> GetFoodNamesContains(string word)

            => _foodRepository.GetFoodNamesContains(word);

        public string GetFoodImageByFoodName(string name)

            => _foodRepository.GetFoodImageByFoodName(name);

        public FoodNutrionals GetFoodNutrionals(string name, int gram)
        {
            var fn = _foodRepository.GetFoodNutritionals(name);

            var calculatedFoodNutrionals = new FoodNutrionals()
            {
                FoodName = fn.FoodName,
                Gram = gram,
                Calorie = Math.Round((fn.Calorie / fn.Gram) * gram, 2),
                Carbonhidrate = Math.Round((fn.Carbonhidrate / fn.Gram) * gram, 2),
                Protein = Math.Round((fn.Protein / fn.Gram) * gram, 2),
                Fat = Math.Round((fn.Fat / fn.Gram) * gram, 2)

            };
            return calculatedFoodNutrionals;

        }

        public Food GetFoodByName(string name)

           => _foodRepository.Get(f => f.Name.Equals(name));

        public void AddNewFood(Food food)
        {
            _foodRepository.Create(food);
        }

        public IEnumerable<int> GetFoodIdsByFoodName(IEnumerable<string> names)

            => _foodRepository.GetFoodIdsByFoodName(names);

    }
}
