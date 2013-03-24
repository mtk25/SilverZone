using System;
using System.Collections.Generic;

namespace SilverZone.Domain.Products
{
    public interface IProductRepository
    {
         // Get all items 
        IList<Product> Get();


        // Get item by key 
        Product Get(Guid id);
    }
}