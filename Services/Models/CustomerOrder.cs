using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public IEnumerable<CustomerOrderDetail> OrderDetails { get; set; }
    }
}
