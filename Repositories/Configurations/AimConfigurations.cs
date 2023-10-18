using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations
{
    public class AimConfigurations : IEntityTypeConfiguration<Aim>
    {
        public void Configure(EntityTypeBuilder<Aim> builder)
        {
            builder.Property(ua => ua.Name).HasMaxLength(50);
            builder.Property(ua => ua.Coefficient).HasMaxLength(4);

            builder.HasData(
                new Aim()
                {
                    Id = 1,
                    Name = "Kilo Verme",
                    Coefficient = 1.0
                },
                new Aim()
                {
                    Id = 2,
                    Name = "Kilo Alma",
                    Coefficient = 1.0
                },
                new Aim()
                {
                    Id = 3,
                    Name = "Kilo Koruma",
                    Coefficient = 1.0
                });
        }
    }
}
