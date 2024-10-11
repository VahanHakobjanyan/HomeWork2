using E_Commerce.Data.Entities;
using E_Commerce.DTOs;

namespace E_Commerce.Services
{
    public interface IProductService
    {
        void CreateProduct(Product productToCreate);
        Product RetrieveProduct(Guid productId);
        void UpdateProduct(Guid productId, ProductInput product);
        void DeleteProduct(Guid productId);
    }
}