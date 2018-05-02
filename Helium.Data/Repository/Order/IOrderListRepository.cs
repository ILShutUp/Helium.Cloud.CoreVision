using System;
using WS.Common.DataKIT;
using WS.Core.Entity.Order;

namespace WS.Core.Data.Repository.Order
{
    public partial interface IOrderListRepository : IRepository<OrderList, int>
    {
    }

    public partial interface IOrderProductRepository : IRepository<OrderProduct, Guid>
    {
    }

    public partial interface IWorkSheetRepository : IRepository<WorkSheet, Guid>
    {
    }
}
