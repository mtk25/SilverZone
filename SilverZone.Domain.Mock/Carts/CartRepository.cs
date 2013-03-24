using System;
using SilverZone.Domain.Carts;

namespace SilverZone.Domain.Mock.Carts
{
    public class CartRepository: ICartRepository
    {
        public Result Save(Cart cart)
        {
            throw new NotImplementedException();
        }

        public Cart Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
