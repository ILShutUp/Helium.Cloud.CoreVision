using Helium.Data.Entity.File.Entity;
using Helium.Tools;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Helium.Data.Entity.Order.Entity
{
    /// <summary>
    ///     工单信息类
    /// </summary>
    [Description("工单信息")]
    public class OrderList : EntityBaseClass<int>
    {
        //工单编号
        [Required]
        public string Odd { get; set; }

        //协议编号
        [Required]
        public string Protocol { get; set; }

        //订单状态: 0-已签约。1-施工中。 2-订单完成 。
        [Required]
        public int State { get; set; }

        public virtual AccessUnit AccessUnit { get; set; }

    }
}
