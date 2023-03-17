namespace HR_ManagementSystem.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }


    }
}
