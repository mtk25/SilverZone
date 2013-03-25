namespace SilverZone.Domain.Carts
{
    public class CartsContainer: ICartsContainer
    {
        public ICartRepository Repository { get; private set; }

        public CartsContainer(ICartRepository repository)
        {
            Repository = repository;
        }
         
    }
}