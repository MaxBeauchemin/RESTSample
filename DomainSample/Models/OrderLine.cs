using System;

namespace DomainSample.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal PricePerItem { get; set; }
        public int Quantity { get; set; }
    }
}
