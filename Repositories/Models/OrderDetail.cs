using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Models
{
    public class OrderDetail
    {
        private static int NextId = 0;
        private int _id;

        public OrderDetail()
        {
            _id = NextId++;
        }

        public int Id { get => _id; }
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
