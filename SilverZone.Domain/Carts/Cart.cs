using System;
using System.Collections.Generic;
using System.Linq;
using SilverZone.Domain.Common;

namespace SilverZone.Domain.Carts
{
    public class Cart
    {
        public Guid Id { get; set; }

        public List<CartItem> Items { get; private set; } 

        public decimal Total 
        {
            get 
            { 
               return Items.Sum(x => x.Total);
            }
        }

        public Guid UserId { get; set; }

        public Cart()
        {
            Items = new List<CartItem>();
        }

        public ShippingInfo ShippingInfo { get; set; }

        public PaymentInfo PaymentInfo { get; set; }


    }
}