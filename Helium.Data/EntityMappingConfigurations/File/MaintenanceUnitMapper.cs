using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Common.DataKIT;
using WS.Core.Entity.File;

namespace WS.Core.Data.Configurations.File
{
    public class MaintenanceUnitMapper : EntityTypeConfiguration<MaintenanceUnit>, IEntityMapper
    {
        public MaintenanceUnitMapper()
        {
            ToTable("MaintenanceUnit");
        }
        public void RegistTo(ConfigurationRegistrar configuration)
        {
            configuration.Add(this);
        }
    }
}
