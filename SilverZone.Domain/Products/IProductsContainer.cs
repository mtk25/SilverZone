namespace SilverZone.Domain.Products
{
    public interface IProductsContainer
    {
        IProductRepository Repository { get; }
    }
}