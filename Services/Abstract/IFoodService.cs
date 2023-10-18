using Entities.Concrete;
using Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface IFoodService
    {
        void AddNewFood(Food food);
        Food GetFoodByName(string name);
        FoodNutrionals GetFoodNutrionals(string name, int gram);
        IEnumerable<int> GetFoodIdsByFoodName(IEnumerable<string> names);
        IEnumerable<string> GetFoodNamesContains(string word);
        string GetFoodImageByFoodName(string name);

    }
}

