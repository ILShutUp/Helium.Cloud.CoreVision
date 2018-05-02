using Helium.Data.Entity.Company.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Helium.Data.EntityMappingConfigurations.Company
{
    public class EmployeeDetailMapper : IEntityTypeConfiguration<EmployeeDetail>
    {
        public void Configure(EntityTypeBuilder<EmployeeDetail> builder)
        {
            builder.HasOne(d => d.Employee).WithOne(e => e.EmployeeDetail);
        }
    }
}
