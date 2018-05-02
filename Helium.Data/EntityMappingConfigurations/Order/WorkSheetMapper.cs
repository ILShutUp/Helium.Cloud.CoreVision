using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using WS.Common.DataKIT;
using WS.Core.Entity.Order;

namespace WS.Core.Data.Configurations.Order
{
    public class WorkSheetMapper : EntityTypeConfiguration<WorkSheet>, IEntityMapper
        {
            public WorkSheetMapper()
            {
                HasRequired(e => e.Employee).WithMany(w => w.WorkSheets);
                ToTable("WorkSheet");
            }

            public void RegistTo(ConfigurationRegistrar configuration)
            {
                configuration.Add(this);
            }
        }    
}