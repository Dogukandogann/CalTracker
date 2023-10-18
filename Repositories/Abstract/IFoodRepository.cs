using Entities.Concrete;
using Repositories.Abstract.Base;
using Services.Concrete;

namespace Repositories.Abstract
{
    public interface IFoodRepository : IBaseRepository<Food>
    {
        IEnumerable<string> GetFoodNamesContains(string word);
        FoodNutrionals GetFoodNutritionals(string word);
        IEnumerable<int> GetFoodIdsByFoodName(IEnumerable<string> names);
        string GetFoodImageByFoodName(string name);
    }
}
