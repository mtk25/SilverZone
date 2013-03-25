namespace SilverZone.Domain.Orders
{
    public interface IOrdersContainer
    {
        IOrderRepository Repository { get; } 
    }
}