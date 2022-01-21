using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public class CustomerOrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
