namespace SilverZone.Domain.Orders
{
    public class OrdersContainer: IOrdersContainer
    {
        public IOrderRepository Repository { get; private set; }

        public OrdersContainer(IOrderRepository repository)
        {
            Repository = repository;
        }
    }
}