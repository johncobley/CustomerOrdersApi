using Repositories.Models;
using Services.Models;
using System.Collections.Generic;

namespace Services
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer);
        IEnumerable<Customer> GetCustomers();
        IEnumerable<CustomerOrder> GetOrdersByCustomerId(int customerId);
    }
}