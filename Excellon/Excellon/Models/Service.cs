namespace Excellon.Models
{
public class Service
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal ChargePerDayPerEmployee { get; set; }

    public List<ClientService> ClientServices { get; set; }
}
}