using System;

namespace SilverZone.Domain.Products
{
    public class Product
    {
        public Guid Id { get; set; }

        public string SKU { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        /// <summary>
        /// Weight is in grams
        /// </summary>
        public int Weight { get; set; }

        public decimal Price { get; set; }

        public bool InStock { get; set; }
    }
}