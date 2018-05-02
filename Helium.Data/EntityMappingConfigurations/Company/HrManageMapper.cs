using Helium.Data.Entity.Company.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Helium.Data.EntityMappingConfigurations.Company
{
    public class HrManageMapper : IEntityTypeConfiguration<HrManage>
    {
        public void Configure(EntityTypeBuilder<HrManage> builder)
        {
            builder.HasOne(e => e.Employee).WithMany(m => m.HrManages);
            builder.HasOne(d => d.Department).WithMany(m => m.HrManages);
            builder.HasOne(p => p.HrPost).WithMany(m => m.HrManages);
        }
    }
}
