using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Common.DataKIT;
using WS.Core.Entity.Inventory;

namespace WS.Core.Data.Configurations.Equipment
{
    public class ProductTypeMapper : EntityTypeConfiguration<ProductType>, IEntityMapper
    {
        public ProductTypeMapper()
        {
            ToTable("ProductType");
        }

        public void RegistTo(ConfigurationRegistrar configuration)
        {
            configuration.Add(this);
        }
    }
}
