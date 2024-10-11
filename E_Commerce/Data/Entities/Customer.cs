namespace E_Commerce.Data.Entities
{
    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public Guid Id { get; set; }

        public Customer() { }
        public Customer(string name, string surname, string address, Guid id)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Id = id;
        }
    }
}
