namespace Excellon.Models
{
    public class Payment
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }
        public bool IsLate { get; set; }
    }
}
