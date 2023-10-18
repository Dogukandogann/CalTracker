using Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations.Extensions
{
    public static class FoodCategoryConfigurationExtensions
    {
        public static void AddSeedData(this EntityTypeBuilder<FoodCategory> builder)
        {
            builder.HasData(
                new FoodCategory() { Id = 1, CategoryName = "Deniz Ürünü" },
                new FoodCategory() { Id = 2, CategoryName = "Tavuk" },
                new FoodCategory() { Id = 3, CategoryName = "Meyve" },
                new FoodCategory() { Id = 4, CategoryName = "Tatlı" },
                new FoodCategory() { Id = 5, CategoryName = "Süt ve Süt Ürünü" },
                new FoodCategory() { Id = 6, CategoryName = "Kırmızı Et" },
                new FoodCategory() { Id = 7, CategoryName = "Kahvaltılık" },
                new FoodCategory() { Id = 8, CategoryName = "Tahıl" },
                new FoodCategory() { Id = 9, CategoryName = "Soslar" },
                new FoodCategory() { Id = 10, CategoryName = "FastFood" },
                new FoodCategory() { Id = 11, CategoryName = "Sebze" },
                new FoodCategory() { Id = 12, CategoryName = "Salatalar" },
                new FoodCategory() { Id = 13, CategoryName = "Çerez" },
                new FoodCategory() { Id = 14, CategoryName = "Çorba" },
                new FoodCategory() { Id = 15, CategoryName = "Yağ" }
            );

        }


    }
}
