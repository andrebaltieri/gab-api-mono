using System;

namespace Gab.Models
{
    public class Cart
    {
        public Cart()
        {
            
        }
        public Cart(Guid product, decimal quantity)
        {
            Id = Guid.NewGuid();
            Product = product;
            Quantity = quantity;
        }
        public Guid Id { get; set; }
        public Guid Product { get; set; }
        public decimal Quantity { get; set; }
    }
}