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
    
    public partial class Product
    {
        public Product()
        {
            this.OrderItems = new HashSet<OrderItem>();
            this.ShoppingCartItems = new HashSet<ShoppingCartItem>();
        }
    
        public System.Guid Id { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public int Grams { get; set; }
    
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
