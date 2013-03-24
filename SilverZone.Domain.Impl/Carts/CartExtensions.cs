using SilverZone.Domain.Carts;

namespace SilverZone.Domain.Impl.Carts
{
    public static class CartExtensions
    {
        public static Cart ToDomainEntity(this Data.ShoppingCart dbShoppingCart)
        {
            return
                dbShoppingCart == null ? null : new Cart
                    {
                        Id = dbShoppingCart.Id,
                        UserId = dbShoppingCart.UserId
                    };
        }

        public static void  UpdateFromDomainEntity(this Data.ShoppingCart dataCart, Cart cart)
        {
            dataCart.Id = cart.Id;
            dataCart.UserId = cart.UserId;
        }


    }
}
