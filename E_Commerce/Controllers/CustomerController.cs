using E_Commerce.DTOs;
using E_Commerce.Data.Entities;
using E_Commerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]

    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public CustomerOutput CreateCustomer(CustomerInput customer)
        {
            _customerService.CreateCustomer(new Customer
            {
                Name = customer.Name,
                Surname = customer.Surname,
                Address = customer.Address,
                Id = customer.Id,
            });
            return new CustomerOutput(customer.Name, customer.Surname, customer.Address);
        }

        [HttpGet]
        [Route("{id}")]
        public CustomerOutput RetrieveCustomer(Guid id)
        {
            var customerToGet = _customerService.RetrieveCustomer(id);
            return new CustomerOutput(customerToGet.Name, customerToGet.Surname, customerToGet.Address);
        }

        [HttpPut]
        [Route("{id}")]
        public void UpdateCustomer(Guid id, CustomerInput updatedCustomer)
        {
            _customerService.UpdateCustomer(id, updatedCustomer);

        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteCustomer(Guid id)
        {
            _customerService.DeleteCustomer(id);
        }

    }
}
