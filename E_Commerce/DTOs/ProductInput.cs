using E_Commerce.Data.Entities;

namespace E_Commerce.DTOs
{
    public class ProductInput
    {
        public string Name { get; set; }
        public Categories Category { get; set; }
        public Guid Id { get; set; }

        public ProductInput(string name, Categories categories, Guid id)
        {
            Name = name;
            Category = categories;
            Id = id;
        }
    }
}
