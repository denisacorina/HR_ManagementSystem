using System.ComponentModel.DataAnnotations;

namespace HR_ManagementSystem.Models
{
    public class BankInfo
    {
        [Key]
        public int Id { get; set; }
        public string BankName { get; set; }
        public string Iban { get; set;}

       


    }
}
