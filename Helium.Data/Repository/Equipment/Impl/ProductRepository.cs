using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WS.Common.DataKIT;
using WS.Core.Entity.Inventory;

namespace WS.Core.Data.Repository.Equipment.Impl
{
    [Export(typeof(IProductRepository))]
    public partial class ProductRepository : EFRepositoryBase<Product,Int32>, IProductRepository
    {
    }
}
