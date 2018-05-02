using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Common.DataKIT;
using WS.Core.Entity.Order;

namespace WS.Core.Data.Configurations.Order
{
    public class OrderListMapper : EntityTypeConfiguration<OrderList> , IEntityMapper
    {
        public OrderListMapper()
        {
            ToTable("OrderList");
        }

        public void RegistTo(ConfigurationRegistrar configuration)
        {
            configuration.Add(this);
        }
    }
}
