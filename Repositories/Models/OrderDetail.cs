using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Models
{
    public class OrderDetail
    {
        private static int NextId = 0;

        public OrderDetail()
        {
            Id = NextId++;
        }

        public int Id { get; private set; }
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
