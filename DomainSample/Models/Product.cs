using System;
using System.Collections.Generic;

namespace DomainSample.Models
{
    public class Product
    {
        public Product()
        {
            this.OrderLines = new List<OrderLine>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
