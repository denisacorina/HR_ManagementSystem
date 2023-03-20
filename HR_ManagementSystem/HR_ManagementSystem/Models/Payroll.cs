using System.ComponentModel.DataAnnotations.Schema;

namespace HR_ManagementSystem.Models
{
    public class Payroll 

    {
    public string PayrollID { get; set; }
    public string NetSalary { get; set; }
    public string Benefits { get; set; }
    public string Deductions { get; set; }
    public string Tax { get; set; } 
    public string CAS { get; set; }
    public string CASS { get; set; }
    public string SalaryPerHour { get; set; }
    
    [ForeignKey("EmployeeId")]

    public virtual int? EmployeeId { get; set; }
    public virtual ICollection<Employee>? Employees { get; set; }


}
}
