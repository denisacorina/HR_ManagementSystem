namespace HR_ManagementSystem.Models
{
    public class PersonalInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public char Gender { get; set; }
        public string CNP { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}
