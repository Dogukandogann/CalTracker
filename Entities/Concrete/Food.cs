using Entities.Abstract;
using Entities.Enums;

namespace Entities.Concrete
{
    public class Food : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public double Calorie { get; set; }
        public double Fat { get; set; }
        public double Carbonhidrate { get; set; }
        public double Protein { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public int Gram { get; set; }
        public int FoodCategoryId { get; set; }
        public FoodCategory FoodCategory { get; set; }
    }
}


