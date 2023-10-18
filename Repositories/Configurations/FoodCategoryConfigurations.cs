using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositories.Configurations.Extensions;

namespace Repositories.Configurations
{
    public class FoodCategoryConfigurations : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.Property(fc => fc.CategoryName).HasMaxLength(50);

            builder.AddSeedData();

        }
    }
}
