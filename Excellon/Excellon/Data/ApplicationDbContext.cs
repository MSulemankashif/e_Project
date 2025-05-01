using Excellon.Models;
using Microsoft.EntityFrameworkCore;


namespace Excellon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Add your DbSets here
        public DbSet<Service> Services { get; set; }
        public DbSet<Client> Clients { get; set; }
        // ... etc.
    }
}
