using System;
using System.Collections.Generic;

namespace SilverZone.Domain.Carts
{
    public class Cart
    {
        public Guid Id { get; set; }

        public List<CartItem> Items { get; set; }

        public Guid UserId { get; set; }
    }
}