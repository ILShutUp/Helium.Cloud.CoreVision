using Helium.Tools;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Helium.Data.Entity.Inventory.Entity
{
    /// <summary>
    ///     产品信息
    /// </summary>

    [Description("产品信息")]
    public class Product : EntityBaseClass<int>
    {
        //产品名称
        [Required]
        public string Name { get; set; }
        
        public virtual ProductType ProductType { get; set; }
    }
}
