using System.ComponentModel.DataAnnotations.Schema;

namespace HR_ManagementSystem.Models
{
    public class Report
    {
        public string ReportId { get; set; }
        public string ReportName { get; set; }



        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }  // relatie one-to-many - un raport poate facut pentru mai multi employee (ex. nr de zile libere ramase pt toti employee)
        public ICollection<Employee>? Employees { get; set; }
    }
}
