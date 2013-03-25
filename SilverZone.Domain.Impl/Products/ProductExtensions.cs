using SilverZone.Domain.Products;

namespace SilverZone.Domain.Impl.Products
{
    public static class ProductExtensions
    {
        public static Product ToDomainEntity(this Data.Product dbProduct)
        {
            Product product = new Product();
            product.Id = dbProduct.Id;
            product.InStock = dbProduct.InStock;
            product.Name = dbProduct.Name;
            product.Price = dbProduct.Price;
            product.SKU = dbProduct.SKU;
            product.Type = dbProduct.Type;
            product.Weight = dbProduct.Grams;

            return product;
        }
    }
}
