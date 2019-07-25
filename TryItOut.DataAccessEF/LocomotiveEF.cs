using System.Data.Entity;
using System.Diagnostics;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccessEF
{
    public class LocomotiveEFContext : DbContext
    {
        public LocomotiveEFContext() : base("name=LarryDataBase") {

            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<Locomotive> LocomotiveEF { get; set; }
    }
}
