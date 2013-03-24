using System;

namespace SilverZone.Domain.Carts
{
    public interface ICartRepository
    {
        //create new cart
        Result Save(Cart cart);

        // get cart by id
        Cart Get(Guid id);
    }
}