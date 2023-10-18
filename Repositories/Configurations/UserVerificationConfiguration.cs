using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configurations
{
    public class UserVerificationConfiguration : IEntityTypeConfiguration<UserVerification>
    {
        public void Configure(EntityTypeBuilder<UserVerification> builder)
        {
            builder.HasKey(uv => uv.UserId);

            builder.HasOne(uv => uv.User)
                   .WithOne(u => u.UserVerification)
                   .HasForeignKey<UserVerification>(uv => uv.UserId);
        }
    }
}
