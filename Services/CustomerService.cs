using Repositories;
using Repositories.Models;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return customerRepository.GetCustomers();
        }

        public void AddCustomer(Customer customer)
        {
            customerRepository.AddCustomer(customer);
        }

        public IEnumerable<CustomerOrder> GetOrdersByCustomerId(int customerId)
        {
            var customerOrders = new List<CustomerOrder>();

            foreach(var orderItem in customerRepository.GetCustomerOrders(customerId))
            {
                var customerOrder = new CustomerOrder { 
                    Id = orderItem.Id,
                    CustomerId = orderItem.CustomerId,
                    OrderDate = orderItem.OrderDate,
                };

                customerOrder.OrderDetails = customerRepository.GetOrderDetailByOrderId(orderItem.Id)
                    .Select(orderDetail => new CustomerOrderDetail
                    {
                        Id = orderDetail.Id,
                        OrderId = orderDetail.OrderId,
                        Price = orderDetail.Price,
                        ProductName = orderDetail.ProductName,
                        Quantity = orderDetail.Quantity
                    }).ToList();   

                customerOrders.Add(customerOrder);
            }

            return customerOrders;
        }
    }
}
