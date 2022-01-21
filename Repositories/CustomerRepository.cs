using Repositories.DataSource;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private Datasource Datasource { get; set; }

        public CustomerRepository(Datasource datasource)
        {
            Datasource = datasource;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return Datasource.Customers.ToList();
        }

        public void AddCustomer(Customer customer)
        {
            Datasource.Customers.Add(customer);
        }

        public IEnumerable<Order> GetCustomerOrders(int customerId)
        {
            return Datasource.Orders.Where(order => order.CustomerId == customerId).ToList();
        }

        public IEnumerable<OrderDetail> GetOrderDetailByOrderId(int orderId)
        {
            return Datasource.OrderItems.Where(orderItem => orderItem.OrderId == orderId).ToList();
        }
    }
}
