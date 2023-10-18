using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Configurations
{
    public class FoodAmountConfiguration : IEntityTypeConfiguration<FoodAmount>
    {
        public void Configure(EntityTypeBuilder<FoodAmount> builder)
        {
            builder.HasKey(fa => new { fa.FoodId, fa.UserMealId });

        }
    }
}
