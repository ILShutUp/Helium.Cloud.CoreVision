using System;
using System.ComponentModel.Composition;
using WS.Common.DataKIT;
using WS.Core.Entity.Inventory;

namespace WS.Core.Data.Repository.Equipment.Impl
{
    [Export(typeof(IProductTypeRepository))]
    public partial class ProductTypeRepository : EFRepositoryBase<ProductType , Int32>, IProductTypeRepository
    {
    }
}
