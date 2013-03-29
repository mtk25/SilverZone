using System;
using System.Collections.Generic;
using System.Linq;

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

        
    }
}