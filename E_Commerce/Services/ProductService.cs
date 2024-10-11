using E_Commerce.Data.Entities;
using E_Commerce.Data.Repository;
using E_Commerce.DTOs;

namespace E_Commerce.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;
        public ProductService()
        {
            _products = ProductRepo.products;
        }
        public void CreateProduct(Product productToCreate)
        {
            if (productToCreate != null)
                _products.Add(productToCreate);
        }

        public void DeleteProduct(Guid productId)
        {
            _products.Remove(_products.FirstOrDefault(p => p.Id == productId));
        }

        public Product RetrieveProduct(Guid productId)
        {
            return _products.FirstOrDefault(p => p.Id == productId);
        }

        public void UpdateProduct(Guid productId, ProductInput product)
        {
            var productToUpdate = _products.FirstOrDefault(p => p.Id == productId);
            productToUpdate.Name = product.Name;
            productToUpdate.Category = product.Category;
        }
    }
}
