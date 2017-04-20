using System;

namespace Gab.Models
{
    public class OrderItem
    {
        public OrderItem()
        {
            
        }
        public OrderItem(Guid product, decimal quantity)
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