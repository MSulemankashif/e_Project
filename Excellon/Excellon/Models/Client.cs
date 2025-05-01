namespace Excellon.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }

        public List<ClientService> ClientServices { get; set; }
        public List<Payment> Payments { get; set; }
    }
}