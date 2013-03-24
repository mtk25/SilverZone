using System;

namespace SilverZone.Domain.Orders
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
    }
}