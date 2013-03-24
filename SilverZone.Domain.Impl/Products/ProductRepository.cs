using System;
using System.Collections.Generic;
using System.Linq;
using SilverZone.Domain.Products;

namespace SilverZone.Domain.Impl.Products
{
    public class ProductRepository: IProductRepository
    {
        public IList<Product> Get()
        {
            List<Product> products = new List<Product>();

            Data.DataContext.UsingContext(
                ctx => products.AddRange(ctx.Products.AsEnumerable().Select(p => p.ToDomainEntity())));

            return products;
        }

        public Product Get(Guid id)
        {
            Product product = null;

            Data.DataContext.UsingContext(ctx => product =  ctx.Products.FirstOrDefault(x => x.Id == id).ToDomainEntity());

            return product;
        }
    }
}
