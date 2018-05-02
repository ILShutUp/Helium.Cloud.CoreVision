using Helium.Data.Entity.Company.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Helium.Data.EntityMappingConfigurations.Company
{
    public class EmployeeMapper : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasOne(e => e.EmployeeDetail).WithOne(d => d.Employee);
            builder.HasMany(m => m.HrManages).WithOne(e => e.Employee);
        }
    }
}

