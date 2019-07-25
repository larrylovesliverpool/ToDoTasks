using System.Data.Entity;
using System.Diagnostics;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccessEF
{
    public class RailwaysManufacturerEFContext : DbContext
    {
        public RailwaysManufacturerEFContext() : base("name=LarryDataBase") {

            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<RailwaysManufacturer> LocomotiveManufacturerEF { get; set; }
    }
}
