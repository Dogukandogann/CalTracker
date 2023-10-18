using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Abstract.Base;
using Repositories.Context;
using Services.Concrete;

namespace Repositories.Concrete.EFCore
{
    public class FoodRepository : BaseRepository<Food>, IFoodRepository
    {
        public IEnumerable<string> GetFoodNamesContains(string word)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            return context.Foods
                            .Where(f => f.Name.Contains(word))
                            .Select(f => f.Name).ToList();
        }

        public FoodNutrionals GetFoodNutritionals(string word)
        {
            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            return context.Foods
                            .Where(f => f.Name.Equals(word))
                            .Select(f => new FoodNutrionals
                            {
                                FoodName = f.Name,
                                Gram = f.Gram,
                                Calorie = f.Calorie,
                                Carbonhidrate = f.Carbonhidrate,
                                Fat = f.Fat,

                            }).FirstOrDefault()!;
        }

        public string GetFoodImageByFoodName(string name)
        {

            using KaloriTakipDbContext context = new KaloriTakipDbContext();
            return context.Foods
                            .Where(f => f.Name.Equals(name))
                            .Select(f => f.ImagePath).FirstOrDefault()!;
        }


        public IEnumerable<int> GetFoodIdsByFoodName(IEnumerable<string> names)
        {
            using var KaloriTakipDbContext = new KaloriTakipDbContext();

            return KaloriTakipDbContext.Foods
            .Where(food => names.Contains(food.Name))
            .Select(food => food.Id).ToList();

        }
    }
}
