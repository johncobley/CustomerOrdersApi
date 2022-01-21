using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Models
{
    public class Order
    {
        private static int NextId = 0;
        private int _id;

        public Order()
        {
            _id = NextId++;
        }

        public int Id { get => _id; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
