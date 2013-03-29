using System;

namespace SilverZone.Domain.Carts
{
    public class CartItem
    {
        public Guid CartId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal Total {
            get { return ProductPrice*Quantity; }
        }
    }
}