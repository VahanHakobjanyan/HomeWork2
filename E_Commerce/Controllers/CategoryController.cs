using E_Commerce.Data.Entities;
using E_Commerce.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController()
        {
            _categoryService = new CategoryService();
        }

        [HttpPost]
        public void CreateCategory(Category category)
        {
            _categoryService.CreateCategory(category);
        }

        [HttpGet]
        [Route("{id}")]
        public Category RetrieveCategory(Guid id)
        {
            return _categoryService.RetrieveCategory(id);
        }

        [HttpPut]
        [Route("{id}")]
        public void UpdateCategory(Guid id, Category category)
        {
            _categoryService.UpdateCategory(id, category);
        }

        [HttpDelete]
        [Route("{id}")]
        public void DeleteCategory(Guid id)
        {
            _categoryService.DeleteCategory(id);
        }
    }
}
