using E_Commerce.Data.Entities;

namespace E_Commerce.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly List<Category> _categories;

        public CategoryService()
        {
            _categories = new List<Category>();
        }

        public void CreateCategory(Category category)
        {
            if (category != null)
                _categories.Add(category);
        }

        public void DeleteCategory(Guid categoryId)
        {
            _categories.Remove(_categories.FirstOrDefault(c => c.Id == categoryId));
        }

        public Category RetrieveCategory(Guid categoryId)
        {
            return _categories.FirstOrDefault(c => c.Id == categoryId);
        }

        public void UpdateCategory(Guid categoryId, Category category)
        {
            var categoryToUpdate = _categories.FirstOrDefault(c => c.Id == categoryId);
            if (categoryToUpdate != null)
                categoryToUpdate.Categories = category.Categories;
        }
    }
}
