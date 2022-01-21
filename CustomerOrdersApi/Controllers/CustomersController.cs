using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repositories.Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerOrdersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly ICustomerService customerService;

        public CustomersController(ILogger<CustomersController> logger, ICustomerService customerService)
        {
            _logger = logger;
            this.customerService = customerService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var customers = customerService.GetCustomers();
            return Ok(customers);
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            customerService.AddCustomer(customer);
            return Ok();
        }

        [HttpGet]
        [Route("{customerId}/orders")]
        public IActionResult GetOrders(int customerId)
        {
            var customerOrders = customerService.GetOrdersByCustomerId(customerId);
            return Ok(customerOrders);
        }
    }
}
