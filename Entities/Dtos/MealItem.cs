namespace Entities.Dtos
{
    public record MealItemDto
    {
        public int UserId { get; init; }
        public string FoodName { get; init; }
        public int Gram { get; init; }
    }
}
