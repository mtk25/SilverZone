namespace SilverZone.Domain.Products
{
    public class ProductsContainer : IProductsContainer
    {
        public IProductRepository Repository { get; private set; }

        public ProductsContainer(IProductRepository repository)
        {
            Repository = repository;
        }

    }
}