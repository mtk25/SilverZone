using System;

namespace SilverZone.Domain.Orders
{
    public interface IOrderRepository
    {
         // create order 
        Result Save(Order order);
        
        
        // get order by id 
        Order Get(Guid id);


        // get orders for user 

    }
}