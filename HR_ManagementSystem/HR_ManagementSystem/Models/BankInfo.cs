namespace HR_ManagementSystem.Models
{
    public class BankInfo
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string Iban { get; set;}

        public int BankInfoId { get; set; }
        public BankInfo BankInfo { get; set; }


    }
}
