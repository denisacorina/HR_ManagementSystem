using System.ComponentModel.DataAnnotations.Schema;
namespace HR_ManagementSystem.Models

{
    public class Attendance
    {
        public int AttendanceID { get; set; }
        public DateTime Date { get; set; }

        public int TotalHoursWorked  { get; set;}

        [ForeignKey("EmployeeId")]
        public virtual int? EmployeeId { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
