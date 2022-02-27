using System;
using System.Collections.Generic;

namespace DomainSample.Models
{
    public class Order
    {
        public Order(){
            this.OrderLines = new List<OrderLine>();
        }

        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? CompletedDateTime { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
