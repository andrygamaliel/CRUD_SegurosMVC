namespace CRUD_SegurosMVC.Models
{
    public class Policy
    {
        public int Id { get; set; }
        public string PolicyNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal PremiumAmount { get; set; }
    }
}
