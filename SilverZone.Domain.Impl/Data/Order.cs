//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilverZone.Domain.Impl.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid UserId { get; set; }
    
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual User User { get; set; }
    }
}
