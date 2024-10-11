using E_Commerce.Data.Entities;

namespace E_Commerce.Data.Repository
{
    public static class ProductRepo
    {
        public static List<Product> products = new List<Product>
        {
            new Product("Smartphone", Categories.Electronics, new Guid("00000000-0000-0000-0000-000000000001")),
                new Product("T-Shirt", Categories.Clothing, new Guid("00000000-0000-0000-0000-000000000002")),
                new Product("Novel", Categories.Books, new Guid("00000000-0000-0000-0000-000000000003")),
                new Product("Microwave", Categories.HomeAppliances, new Guid("00000000-0000-0000-0000-000000000004")),
                new Product("Action Figure", Categories.Toys, new Guid("00000000-0000-0000-0000-000000000005")),
                new Product("Basketball", Categories.Sports, new Guid("00000000-0000-0000-0000-000000000006")),
                new Product("Lipstick", Categories.Beauty, new Guid("00000000-0000-0000-0000-000000000007")),
                new Product("Car Oil", Categories.Automotive, new Guid("00000000-0000-0000-0000-000000000008")),
                new Product("Sofa", Categories.Furniture, new Guid("00000000-0000-0000-0000-000000000009")),
                new Product("Rice", Categories.Grocery, new Guid("00000000-0000-0000-0000-00000000000A")),
                new Product("Laptop", Categories.Electronics, new Guid("00000000-0000-0000-0000-00000000000B")),
                new Product("Jeans", Categories.Clothing, new Guid("00000000-0000-0000-0000-00000000000C")),
                new Product("Cookbook", Categories.Books, new Guid("00000000-0000-0000-0000-00000000000D")),
                new Product("Vacuum Cleaner", Categories.HomeAppliances, new Guid("00000000-0000-0000-0000-00000000000E")),
                new Product("Puzzle", Categories.Toys, new Guid("00000000-0000-0000-0000-00000000000F")),
                new Product("Football", Categories.Sports, new Guid("00000000-0000-0000-0000-000000000010")),
                new Product("Foundation", Categories.Beauty, new Guid("00000000-0000-0000-0000-000000000011")),
                new Product("Car Battery", Categories.Automotive, new Guid("00000000-0000-0000-0000-000000000012")),
                new Product("Dining Table", Categories.Furniture, new Guid("00000000-0000-0000-0000-000000000013")),
                new Product("Pasta", Categories.Grocery, new Guid("00000000-0000-0000-0000-000000000014")),
                new Product("Camera", Categories.Electronics, new Guid("00000000-0000-0000-0000-000000000015")),
                new Product("Jacket", Categories.Clothing, new Guid("00000000-0000-0000-0000-000000000016")),
                new Product("Sci-Fi Novel", Categories.Books, new Guid("00000000-0000-0000-0000-000000000017")),
                new Product("Air Conditioner", Categories.HomeAppliances, new Guid("00000000-0000-0000-0000-000000000018")),
                new Product("Board Game", Categories.Toys, new Guid("00000000-0000-0000-0000-000000000019")),
                new Product("Tennis Racket", Categories.Sports, new Guid("00000000-0000-0000-0000-00000000001A")),
                new Product("Shampoo", Categories.Beauty, new Guid("00000000-0000-0000-0000-00000000001B")),
                new Product("Tire", Categories.Automotive, new Guid("00000000-0000-0000-0000-00000000001C")),
                new Product("Bookshelf", Categories.Furniture, new Guid("00000000-0000-0000-0000-00000000001D")),
                new Product("Coffee", Categories.Grocery, new Guid("00000000-0000-0000-0000-00000000001E")),
                new Product("Headphones", Categories.Electronics, new Guid("00000000-0000-0000-0000-00000000001F")),
                new Product("Sweater", Categories.Clothing, new Guid("00000000-0000-0000-0000-000000000020")),
                new Product("Travel Guide", Categories.Books, new Guid("00000000-0000-0000-0000-000000000021")),
                new Product("Blender", Categories.HomeAppliances, new Guid("00000000-0000-0000-0000-000000000022")),
                new Product("Doll", Categories.Toys, new Guid("00000000-0000-0000-0000-000000000023")),
                new Product("Soccer Ball", Categories.Sports, new Guid("00000000-0000-0000-0000-000000000024")),
                new Product("Face Cream", Categories.Beauty, new Guid("00000000-0000-0000-0000-000000000025")),
                new Product("Windshield Wiper", Categories.Automotive, new Guid("00000000-0000-0000-0000-000000000026")),
                new Product("Armchair", Categories.Furniture, new Guid("00000000-0000-0000-0000-000000000027")),
                new Product("Olive Oil", Categories.Grocery, new Guid("00000000-0000-0000-0000-000000000028")),
                new Product("Smartwatch", Categories.Electronics, new Guid("00000000-0000-0000-0000-000000000029")),
                new Product("Socks", Categories.Clothing, new Guid("00000000-0000-0000-0000-00000000002A")),
                new Product("Mystery Book", Categories.Books, new Guid("00000000-0000-0000-0000-00000000002B")),
                new Product("Toaster", Categories.HomeAppliances, new Guid("00000000-0000-0000-0000-00000000002C")),
                new Product("Toy Car", Categories.Toys, new Guid("00000000-0000-0000-0000-00000000002D")),
                new Product("Golf Club", Categories.Sports, new Guid("00000000-0000-0000-0000-00000000002E")),
                new Product("Nail Polish", Categories.Beauty, new Guid("00000000-0000-0000-0000-00000000002F")),
                new Product("Car Cover", Categories.Automotive, new Guid("00000000-0000-0000-0000-000000000030")),
                new Product("Wardrobe", Categories.Furniture, new Guid("00000000-0000-0000-0000-000000000031")),
                new Product("Tea", Categories.Grocery, new Guid("00000000-0000-0000-0000-000000000032"))
        };
    }
}
