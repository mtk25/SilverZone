using System;
using System.Collections.Generic;
using SilverZone.Domain.Products;

namespace SilverZone.Domain.Mock.Products
{
    public class ProductRepository : IProductRepository
    {
        public IList<Product> Get()
        {
            throw new NotImplementedException();
        }

        public Product Get(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
