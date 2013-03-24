using System;
using SilverZone.Domain.Orders;

namespace SilverZone.Domain.Mock.Orders
{
    public class OrderRepository : IOrderRepository
    {
        public Result Save(Order order)
        {
            throw new NotImplementedException();
        }

        public Order Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
