using Entities.Concrete;
using Repositories.Abstract;
using Repositories.Abstract.Base;
using Repositories.Context;

namespace Repositories.Concrete.EFCore
{
    public class FoodCategoryRepository : BaseRepository<FoodCategory>, IFoodCategoryRepository
    {
        public IEnumerable<string> GetCategoryNames()
        {
            using var context = new KaloriTakipDbContext();

            return context.FoodCategories.Select(fc => fc.CategoryName).ToList();

        }
    }
}
