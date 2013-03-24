using System;
using System.Linq;
using SilverZone.Domain.Orders;

namespace SilverZone.Domain.Impl.Orders
{
    public class OrderRepository: IOrderRepository
    {
        public Result Save(Order order)
        {
            if(order == null)
                throw new ArgumentNullException("order");

            Result result = new Result();

            Data.DataContext.UsingContext(ctx =>
                {
                    Data.Order dataOrder;
                    
                    //check if there is no order
                    bool isNew = order.Id == Guid.Empty;

                    if (isNew)
                    {
                        order.Id = Guid.NewGuid();
                        //add
                        dataOrder = new Data.Order();
                    }
                    else
                    {
                        //update order
                        dataOrder = ctx.Orders.FirstOrDefault(x => x.Id == order.Id);
                        if (dataOrder == null)
                        {
                            result.HasErrors = true;
                            result.Message ="Order is not found: " + order.Id;

                        }
                    }

                    if (!result.HasErrors)
                    {
                        // update data order from domain order
                        dataOrder.UpdateFromDomainEntity(order);

                        if (isNew)
                        {
                            ctx.Orders.Add(dataOrder);
                        }
                    }


                });



            return result;
        }

        public Order Get(Guid id)
        {
            Order order = null;
            Data.DataContext.UsingContext(
                ctx =>
                    {
                        // set domain value
                        order = 
                            // find data entity by id
                            ctx.Orders.FirstOrDefault(x => x.Id == id )
                            // convert data entity to domain entity
                            .ToDomainEntity();
                    }
                );

            return order;
        }
    }
}
