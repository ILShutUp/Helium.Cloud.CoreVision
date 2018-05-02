using Helium.Data.Entity.Account.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Helium.Data.EntityMappingConfigurations.Account
{
    public class LoginLOGMapper : IEntityTypeConfiguration<LoginLog>
    {
        public void Configure(EntityTypeBuilder<LoginLog> builder)
        {
            builder.HasOne(e => e.Employee).WithMany(l => l.LoginLogs);
        }
    }
}

