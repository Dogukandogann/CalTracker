namespace Services.Concrete
{
    public record FoodNutrionals
    {
        public string FoodName { get; init; }
        public int Gram { get; init; }
        public double Calorie { get; init; }
        public double Carbonhidrate { get; init; }
        public double Protein { get; init; }
        public double Fat { get; init; }


    }

}
