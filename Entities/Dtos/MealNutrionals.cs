using Entities.Enums;
using Services.Concrete;

namespace Entities.Dtos
{
    public record MealNutrionals
    {
        public MealTimes MealTime { get; init; }
        public double Calorie { get; init; }
        public double Carbonhidrate { get; init; }
        public double Protein { get; init; }
        public double Fat { get; init; }
    }
}
