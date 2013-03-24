using System;
using System.Linq;
using SilverZone.Domain.Carts;

namespace SilverZone.Domain.Impl.Carts
{
    public class CartRepository : ICartRepository
    {
        public Result Save(Cart cart)
        {
           if(cart == null)
               throw new ArgumentNullException("cart");

        Result result = new Result();
        
            Data.DataContext.UsingContext(ctx =>
                {
                    Data.ShoppingCart dataCart;

                    //check cart - if it exists
                    bool isNew = cart.Id == Guid.Empty;

                    if (isNew)
                    {
                        cart.Id = Guid.NewGuid();

                        //add
                        dataCart = new Data.ShoppingCart();
                    }
                    else
                    {
                        //update 
                        dataCart = ctx.ShoppingCarts.FirstOrDefault(x => x.Id == cart.Id);

                        if (dataCart == null)
                        {
                            result.HasErrors = true;
                            result.Message = "Cart is not found" + cart.Id;

                        }
                    }

                    if (!result.HasErrors)
                    {
                        // update data cart from domain cart
                        dataCart.UpdateFromDomainEntity(cart);

                        if (isNew)
                        {
                            ctx.ShoppingCarts.Add(dataCart);
                        }
                    }
                });

            return result;

        }

        public Cart Get(Guid id)
        {
            Cart cart = null;
            Data.DataContext.UsingContext(
                ctx =>
                {
                    cart = ctx.ShoppingCarts.FirstOrDefault(x => x.Id == id).ToDomainEntity();
                }
                );
            return cart;

        }
    }
}
