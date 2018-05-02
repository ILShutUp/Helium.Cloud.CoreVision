using System;

namespace Helium.Data.Entity.Order.Info
{
    public class OrderProductInfo
    {
        public Guid Id { get; set; }

        public string Odd { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public string Code { get; set; }
    }
}
