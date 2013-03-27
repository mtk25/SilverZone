namespace SilverZone.Domain.Carts
{
    public interface ICartsContainer
    {
        ICartRepository Repository { get; }

        ICartService Service { get; }
    }
}