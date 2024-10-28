using System.Data.Entity;

namespace TDSA.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() : base("name=TDSA")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}