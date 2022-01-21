using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.DataSource
{
    public class Datasource
    {
        public List<Customer> Customers;
        public List<Order> Orders;
        public List<OrderDetail> OrderItems;

        // Generate out database
        public Datasource()
        {
            Customers = new List<Customer> {
                new Customer{ Name = "Oliver Bond" },
                new Customer{ Name = "Sean Kelly" },
                new Customer{ Name = "James Woodhall"}
            };

            Orders = new List<Order>
            {
                new Order { CustomerId = 0, OrderDate = DateTime.Now }
            };

            OrderItems = new List<OrderDetail>
            {
                new OrderDetail { OrderId = 0, ProductName = "Rice Krispies", Price = 1.25M, Quantity = 1 },
                new OrderDetail { OrderId = 0, ProductName = "Bag of Rice", Price = 0.75M, Quantity = 6 }
            };
        }
    }
}
