using Repositories.Models;
using System.Collections.Generic;

namespace Repositories
{
    public interface ICustomerRepository
    {
        void AddCustomer(Customer customer);
        IEnumerable<Order> GetCustomerOrders(int customerId);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<OrderDetail> GetOrderDetailByOrderId(int orderId);
    }
}