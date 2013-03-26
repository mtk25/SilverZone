using System;
using System.Collections.Generic;

namespace SilverZone.Domain.Products
{
    public interface IProductRepository
    {
         // Get all items 
        IList<Product> Get(int productCategoryId);


        // Get item by key 
        Product Get(Guid id);

        IList<ProductCategory> GetCategories();
    }
}