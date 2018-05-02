using Helium.Data.Entity.Company.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Helium.Data.EntityMappingConfigurations.Company
{
    public class HrPostMapper : IEntityTypeConfiguration<HrPost>
    {
        public void Configure(EntityTypeBuilder<HrPost> builder)
        {
            builder.HasMany(m => m.HrManages).WithOne(p => p.HrPost);
        }
    }
}

