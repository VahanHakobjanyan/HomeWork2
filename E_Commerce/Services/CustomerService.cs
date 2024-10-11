using E_Commerce.Data.Entities;
using E_Commerce.Data.Repository;
using E_Commerce.DTOs;

namespace E_Commerce.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly List<Customer> _customers;

        public CustomerService() 
        {
            _customers = CustomerRepo.customers;
        }
        public void CreateCustomer(Customer customer)
        {
            if (customer != null)
            {
                _customers.Add(customer);
            }
        }

        public Customer RetrieveCustomer(Guid customerId)
        {
            return _customers.FirstOrDefault(x => x.Id == customerId);
        }
        public IEnumerable<Customer> RetrieveAllCustomers()
        {
            return _customers;
        }

        public void UpdateCustomer(Guid customerId, CustomerInput customer)
        {
            var customerToUpdate = _customers.FirstOrDefault(x => x.Id == customerId);
            if (customerToUpdate != null && customer != null)
            {
                customerToUpdate.Name = customer.Name;
                customerToUpdate.Surname = customer.Surname;
                customerToUpdate.Address = customer.Address;
            }
        }

        public void DeleteCustomer(Guid customerId)
        {
            _customers.Remove(_customers.FirstOrDefault(x => x.Id == customerId));
        }
    }
}
