using E_Commerce.Data.Entities;

namespace E_Commerce.DTOs
{
    public class ProductOutput
    {
        public string Name { get; set; }
        public Categories Category { get; set; }
        public ProductOutput()
        {
            
        }
        public ProductOutput(string name, Categories category)
        {
            Name = name;
            Category = category;
        }
    }
}
