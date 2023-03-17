namespace HR_ManagementSystem.Models
{
    public class Employee
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string ManagerName { get; set; }
        public bool IsHr { get; set; }
        public int PersonalInfoID { get; set; }
        public PersonalInfo PersonalInfo { get; set; }
        

    }
}
