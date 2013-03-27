namespace SilverZone.Domain.Carts
{
    public class CartsContainer: ICartsContainer
    {
        public ICartRepository Repository { get; private set; }

        public ICartService Service { get; private set; }

        public CartsContainer(ICartRepository repository, ICartService service)
        {
            Repository = repository;
            Service = service;
        }
    }
}