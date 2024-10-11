namespace E_Commerce.Data.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public Categories Category {  get; set; }
        public Guid Id { get; set; }

        public Product(string name, Categories category, Guid id)
        {
            Name = name;
            Category = category;
            Id = id;
        }
    }
}
