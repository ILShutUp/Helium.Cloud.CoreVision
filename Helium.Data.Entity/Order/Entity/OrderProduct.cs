using Helium.Data.Entity.Inventory.Entity;
using Helium.Tools;
using System;
using System.ComponentModel;

namespace Helium.Data.Entity.Order.Entity
{
    /// <summary>
    ///     工单产品列表类
    /// </summary>
    [Description("工单包含产品信息")]
    public class OrderProduct : EntityBaseClass<Guid>
    {
        public OrderProduct()
        {
            ID = CombHelper.NewComb();
        }
        
        //获取的工单编号
        public virtual OrderList OrderList { get; set; }

        //产品编号
        public virtual Product Product { get; set; }

        //数量
        public int Quantity { get; set; }

        //设备编号
        public string Code { get; set; }
    }
}
