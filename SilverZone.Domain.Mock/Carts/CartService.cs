using System;
using System.Collections.Generic;
using SilverZone.Domain.Carts;

namespace SilverZone.Domain.Mock.Carts
{
   public class CartService: ICartService 
    {
       Dictionary<Guid, Cart> carts = new Dictionary<Guid, Cart>();

       public Cart GetCart(Guid userId)
       {
           Cart cart;
           
           // check if user has cart
           if (carts.ContainsKey(userId))
           {
               cart = carts[userId];
           }
           else
           {
               cart = new Cart();
               cart.UserId = userId;

               carts.Add(cart.UserId,cart);
           }
           
           return cart;
       }
    }
}
