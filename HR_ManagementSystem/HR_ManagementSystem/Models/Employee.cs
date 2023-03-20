using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HR_ManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(?=.\d)(?=.[a-z])(?=.*[A-Z]).{8,}$",
            ErrorMessage = "The password must contain at least one digit, one lowercase and one uppercase character, and be at least 8 characters long.")]
        public string Password { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string ManagerName { get; set; }
        public bool IsHr { get; set; }

        [ForeignKey("PersonalInfoID")] // relatie one-to-one - un employee poate avea doar un personalInfo
        public int? PersonalInfoID { get; set; }
        public PersonalInfo? PersonalInfo { get; set; }

        [ForeignKey("Reports")]
        public int? ReportId { get; set; }  // relatie one-to-many - un employee poate avea mai multe rapoarte
        public ICollection<Report>? Reports { get; set; }


    }
}
