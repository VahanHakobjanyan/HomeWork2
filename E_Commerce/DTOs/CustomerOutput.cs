namespace E_Commerce.DTOs
{
    public class CustomerOutput
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public CustomerOutput()
        {
            
        }

        public CustomerOutput(string name, string surname, string address)
        {
            Name = name;
            Surname = surname;
            Address = address;
        }
    }
}
