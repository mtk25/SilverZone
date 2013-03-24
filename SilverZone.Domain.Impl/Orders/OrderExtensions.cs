using SilverZone.Domain.Orders;

namespace SilverZone.Domain.Impl.Orders
{
    public static class OrderExtensions
    {
        public static Order ToDomainEntity(this Data.Order dbOrder)
        {
            return
                dbOrder == null
                    ? null
                    : new Order
                        {
                            Id = dbOrder.Id,
                            UserId = dbOrder.UserId
                        };
        }

        public static void UpdateFromDomainEntity(this Data.Order dataOrder, Order order)
        {
            dataOrder.Id = order.Id;
            dataOrder.UserId = order.UserId;

        }

    }
}
