using System.ComponentModel.DataAnnotations;

namespace HR_ManagementSystem.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
      


    }
}
