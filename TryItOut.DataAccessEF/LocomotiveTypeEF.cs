using System.Data.Entity;
using System.Diagnostics;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccessEF
{
    public class LocomotiveTypeEFContext : DbContext
    {
        public LocomotiveTypeEFContext() : base("name=LarryDataBase") {

            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<LocomotiveClassification> LocomotiveClassificationEF { get; set; }
    }
}
