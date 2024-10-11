using E_Commerce.Data.Entities;
using E_Commerce.DTOs;

namespace E_Commerce.Services
{
    public interface ICustomerService
    {
        void CreateCustomer(Customer customer);
        Customer RetrieveCustomer(Guid customerId);

        void UpdateCustomer(Guid customerId, CustomerInput customer);
        void DeleteCustomer(Guid customerId);
    }
}