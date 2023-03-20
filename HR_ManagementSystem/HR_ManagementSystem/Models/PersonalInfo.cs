using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_ManagementSystem.Models
{
    public class PersonalInfo
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public char Gender { get; set; }
        public string CNP { get; set; }
        public DateTime DateOfBirth { get; set; }

        [ForeignKey("AddressID")]  // relatie one-to-one - un personalInfo poate avea doar o adresa
        public int? AddressId { get; set; }
        public Address? Address { get; set; }

        [ForeignKey("BankInfoId")] // relatie one-to-one - un personalInfo poate avea doar o banca
        public int? BankInfoId { get; set; }
        public BankInfo? BankInfo { get; set; }


    }
}
