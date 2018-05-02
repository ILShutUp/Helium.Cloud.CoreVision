using System;
using System.ComponentModel.Composition;
using WS.Common.DataKIT;
using WS.Core.Entity.Order;

namespace WS.Core.Data.Repository.Order.Impl
{
    [Export(typeof(IOrderListRepository))]
    public partial class OrderListRepository : EFRepositoryBase<OrderList, Int32>, IOrderListRepository
    {
    }

    [Export(typeof(IOrderProductRepository))]
    public partial class OrderProductRepository : EFRepositoryBase<OrderProduct, Guid>, IOrderProductRepository
    {
    }

    [Export(typeof(IWorkSheetRepository))]
    public partial class WorkSheetRepository : EFRepositoryBase<WorkSheet, Guid>, IWorkSheetRepository
    {
    }
}
