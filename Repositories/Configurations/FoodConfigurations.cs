using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositories.Configurations.Extensions;

namespace Repository.Configurations
{
    public class FoodConfigurations : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasIndex(f => f.Name).IsUnique();
            builder.Property(f => f.Name).HasMaxLength(100);
            builder.Property(f => f.Calorie).HasMaxLength(8);
            builder.Property(f => f.Fat).HasMaxLength(8);
            builder.Property(f => f.Carbonhidrate).HasMaxLength(8);
            builder.Property(f => f.Protein).HasMaxLength(8); 
            builder.AddSeedData();

            
        }        
    }
}
