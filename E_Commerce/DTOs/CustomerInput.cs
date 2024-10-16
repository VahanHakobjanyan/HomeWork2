namespace E_Commerce.DTOs
{
    public class CustomerInput
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public Guid Id { get; set; }

        public CustomerInput()
        {

        }
        public CustomerInput(string name, string surname, string address, Guid id)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Id = id;
        }
    }
}
