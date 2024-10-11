using E_Commerce.DTOs;
using E_Commerce.Data.Entities;
using E_Commerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public ProductOutput CreateProduct(ProductInput input)
        {
            var productToCreate = new Product(input.Name, input.Category, input.Id);
            _productService.CreateProduct(productToCreate);
            return new ProductOutput(input.Name, input.Category);
        }

        [HttpGet]
        [Route("{id}")]
        public ProductOutput GetProduct(Guid id)
        {
            var ProductToGet = _productService.RetrieveProduct(id);
            return new ProductOutput(ProductToGet.Name, ProductToGet.Category);
        }

        [HttpPut]
        [Route("{id}")]
        public void PostProduct(Guid id, ProductInput input)
        {
            _productService.UpdateProduct(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteProduct(Guid id)
        {
            _productService.DeleteProduct(id);
        }
    }
}
