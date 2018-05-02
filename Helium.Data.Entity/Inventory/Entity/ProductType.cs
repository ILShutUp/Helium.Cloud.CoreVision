using Helium.Tools;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Helium.Data.Entity.Inventory.Entity
{
    /// <summary>
    ///     产品类型信息类
    /// </summary>

    [Description("产品类型")]
    public class ProductType : EntityBaseClass<int>
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
