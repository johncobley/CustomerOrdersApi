using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Models
{
    public class Order
    {
        private static int NextId = 0;

        public Order()
        {
            Id = NextId++;
        }

        public int Id { get; private set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
