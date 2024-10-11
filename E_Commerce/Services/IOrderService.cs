using E_Commerce.Data.Entities;

namespace E_Commerce.Services
{
    public interface IOrderService
    {
        void CreateOrder(Order order);
        void RetrieveOrder(Guid orderId);
        void UpdateOrder(Guid orderId);
        void DeleteOrder(Guid orderId);
    }
}