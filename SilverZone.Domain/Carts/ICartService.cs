using System;

namespace SilverZone.Domain.Carts
{
    public interface ICartService
    {
        Cart GetCart(Guid userId);
    }
}