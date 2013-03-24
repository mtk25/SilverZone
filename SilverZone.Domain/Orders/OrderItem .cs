using System;

namespace SilverZone.Domain.Orders
{
    public class OrderItem 
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }
    }
}