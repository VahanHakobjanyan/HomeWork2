using E_Commerce.Data.Entities;

namespace E_Commerce.Data.Repository
{
    public static class CustomerRepo
    {
        public static List<Customer> customers = new List<Customer>
            {
               new Customer("Alice", "Smith", "123 Elm St", new Guid("00000000-0000-0000-0000-000000000001")),
                new Customer("Bob", "Johnson", "456 Oak St", new Guid("00000000-0000-0000-0000-000000000002")),
                new Customer("Charlie", "Williams", "789 Pine St", new Guid("00000000-0000-0000-0000-000000000003")),
                new Customer("David", "Brown", "135 Maple St", new Guid("00000000-0000-0000-0000-000000000004")),
                new Customer("Eva", "Davis", "246 Cedar St", new Guid("00000000-0000-0000-0000-000000000005")),
                new Customer("Frank", "Garcia", "357 Birch St", new Guid("00000000-0000-0000-0000-000000000006")),
                new Customer("Grace", "Martinez", "468 Spruce St", new Guid("00000000-0000-0000-0000-000000000007")),
                new Customer("Henry", "Hernandez", "579 Elm St", new Guid("00000000-0000-0000-0000-000000000008")),
                new Customer("Irene", "Lopez", "680 Oak St", new Guid("00000000-0000-0000-0000-000000000009")),
                new Customer("Jack", "Wilson", "791 Pine St", new Guid("00000000-0000-0000-0000-00000000000A")),
                new Customer("Kathy", "Anderson", "802 Maple St", new Guid("00000000-0000-0000-0000-00000000000B")),
                new Customer("Leo", "Thomas", "913 Cedar St", new Guid("00000000-0000-0000-0000-00000000000C")),
                new Customer("Mia", "Taylor", "024 Birch St", new Guid("00000000-0000-0000-0000-00000000000D")),
                new Customer("Nate", "Moore", "135 Spruce St", new Guid("00000000-0000-0000-0000-00000000000E")),
                new Customer("Olivia", "Jackson", "246 Elm St", new Guid("00000000-0000-0000-0000-00000000000F")),
                new Customer("Paul", "White", "357 Oak St", new Guid("00000000-0000-0000-0000-000000000010")),
                new Customer("Quinn", "Harris", "468 Pine St", new Guid("00000000-0000-0000-0000-000000000011")),
                new Customer("Rachel", "Martin", "579 Maple St", new Guid("00000000-0000-0000-0000-000000000012")),
                new Customer("Steve", "Thompson", "680 Cedar St", new Guid("00000000-0000-0000-0000-000000000013")),
                new Customer("Tina", "Garcia", "791 Birch St", new Guid("00000000-0000-0000-0000-000000000014")),
                new Customer("Ursula", "Martinez", "802 Spruce St", new Guid("00000000-0000-0000-0000-000000000015")),
                new Customer("Victor", "Robinson", "913 Elm St", new Guid("00000000-0000-0000-0000-000000000016")),
                new Customer("Wendy", "Clark", "024 Oak St", new Guid("00000000-0000-0000-0000-000000000017")),
                new Customer("Xander", "Rodriguez", "135 Pine St", new Guid("00000000-0000-0000-0000-000000000018")),
                new Customer("Yara", "Lewis", "246 Maple St", new Guid("00000000-0000-0000-0000-000000000019")),
                new Customer("Zach", "Lee", "357 Cedar St", new Guid("00000000-0000-0000-0000-00000000001A")),
                new Customer("Anna", "Walker", "468 Birch St", new Guid("00000000-0000-0000-0000-00000000001B")),
                new Customer("Brian", "Hall", "579 Spruce St", new Guid("00000000-0000-0000-0000-00000000001C")),
                new Customer("Cathy", "Allen", "680 Elm St", new Guid("00000000-0000-0000-0000-00000000001D")),
                new Customer("Daniel", "Young", "791 Oak St", new Guid("00000000-0000-0000-0000-00000000001E")),
                new Customer("Emily", "Hernandez", "802 Pine St", new Guid("00000000-0000-0000-0000-00000000001F")),
                new Customer("Felix", "King", "913 Maple St", new Guid("00000000-0000-0000-0000-000000000020")),
                new Customer("Gina", "Wright", "024 Cedar St", new Guid("00000000-0000-0000-0000-000000000021")),
                new Customer("Henry", "Scott", "135 Birch St", new Guid("00000000-0000-0000-0000-000000000022")),
                new Customer("Isla", "Green", "246 Spruce St", new Guid("00000000-0000-0000-0000-000000000023")),
                new Customer("Jake", "Adams", "357 Elm St", new Guid("00000000-0000-0000-0000-000000000024")),
                new Customer("Kate", "Nelson", "468 Oak St", new Guid("00000000-0000-0000-0000-000000000025")),
                new Customer("Leo", "Harris", "579 Pine St", new Guid("00000000-0000-0000-0000-000000000026")),
                new Customer("Maya", "Clark", "680 Maple St", new Guid("00000000-0000-0000-0000-000000000027")),
                new Customer("Noah", "Lewis", "791 Cedar St", new Guid("00000000-0000-0000-0000-000000000028")),
                new Customer("Olivia", "Allen", "802 Birch St", new Guid("00000000-0000-0000-0000-000000000029")),
                new Customer("Peter", "Walker", "913 Spruce St", new Guid("00000000-0000-0000-0000-00000000002A")),
                new Customer("Quincy", "Young", "024 Elm St", new Guid("00000000-0000-0000-0000-00000000002B")),
                new Customer("Rita", "Hernandez", "135 Oak St", new Guid("00000000-0000-0000-0000-00000000002C")),
                new Customer("Steve", "Martinez", "246 Pine St", new Guid("00000000-0000-0000-0000-00000000002D")),
                new Customer("Tina", "Robinson", "357 Maple St", new Guid("00000000-0000-0000-0000-00000000002E")),
                new Customer("Ursula", "Scott", "468 Cedar St", new Guid("00000000-0000-0000-0000-00000000002F")),
                new Customer("Victor", "Wright", "579 Birch St", new Guid("00000000-0000-0000-0000-000000000030")),
                new Customer("Wendy", "Johnson", "680 Spruce St", new Guid("00000000-0000-0000-0000-000000000031")),
                new Customer("Xena", "Adams", "791 Elm St", new Guid("00000000-0000-0000-0000-000000000032")),
                new Customer("Yara", "Garcia", "802 Oak St", new Guid("00000000-0000-0000-0000-000000000033")),
                new Customer("Zara", "Martinez", "913 Pine St", new Guid("00000000-0000-0000-0000-000000000034"))
            };
    }
}
