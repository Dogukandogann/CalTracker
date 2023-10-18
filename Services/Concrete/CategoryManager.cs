using Repositories.Abstract;
using Repositories.Concrete.EFCore;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly IFoodCategoryRepository _foodCategoryRepository = new FoodCategoryRepository();

        public IEnumerable<string> GetCategoryNames()
        {
            return _foodCategoryRepository.GetCategoryNames();
        }

    }
}
