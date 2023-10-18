using Entities.Concrete;
using Repositories.Abstract.Base;

namespace Repositories.Abstract
{
    public interface IFoodCategoryRepository : IBaseRepository<FoodCategory>
    {
        IEnumerable<string> GetCategoryNames();
    }
}
