namespace E_Commerce.Data.Entities
{
    public class Category
    {
        public Categories Categories { get; set; }
        public Guid Id { get; set; }

        public Category(Categories categories, Guid categoryId)
        {
            Categories = categories;
            Id = categoryId;
        }
    }

    [Flags]
    public enum Categories
    {
        Electronics = 1,
        Clothing = 2,
        Books = 4,
        HomeAppliances = 8,
        Toys = 16,
        Sports = 32,
        Beauty = 64,
        Automotive = 128,
        Furniture = 256,
        Grocery = 512,
    }
}
