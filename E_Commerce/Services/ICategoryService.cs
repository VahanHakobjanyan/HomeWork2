using E_Commerce.Data.Entities;

namespace E_Commerce.Services
{
    public interface ICategoryService
    {
        void CreateCategory(Category category);
        Category RetrieveCategory(Guid categoryId);
        void UpdateCategory(Guid categoryId, Category category);
        void DeleteCategory(Guid categoryId);
    }
}