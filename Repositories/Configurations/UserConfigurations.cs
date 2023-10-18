using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Repositories.Configurations.Extensions;

namespace Repositories.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(20);
            builder.Property(u => u.LastName).HasMaxLength(30);
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.Property(u => u.Height).HasMaxLength(5);
            builder.Property(u => u.Weight).HasMaxLength(5);

            builder.AddSeedData();

        }
    }
}

