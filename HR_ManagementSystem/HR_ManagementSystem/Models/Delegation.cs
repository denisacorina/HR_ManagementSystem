using System.ComponentModel.DataAnnotations.Schema;

namespace HR_ManagementSystem.Models
{
    public class Delegation

    {
        public int DelegationID { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Location { get; set; }

        public string Delegator { get; set; }

        public string Price { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual int? EmployeeId { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }

    }
}
