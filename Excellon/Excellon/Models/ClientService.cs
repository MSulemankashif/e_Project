namespace Excellon.Models
{
    public class ClientService
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public DateTime DateOpted { get; set; }
        public int NoOfEmployees { get; set; }
    }
}
