using System.Data.Entity;
using System.Data.Objects;
using System.Diagnostics;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccessEF
{
    public class RailwaysContextEF : DbContext
    {
        public RailwaysContextEF() : base("name=LarryDataBase")
        {
            Debug.Write(Database.Connection.ConnectionString);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Locomotive> LocomotiveEF { get; set; }

        public DbSet<LocomotiveClassification> LocomotiveClassificationEF { get; set; }

        public DbSet<DecoderCVValue> DecoderCVValueEF { get; set; }

        public DbSet<RailwaysManufacturer> RailwaysManufacturerEF { get; set; }

        public DbSet<RailwayDecoder> RailwayDecoderEF { get; set; }

        public DbSet<LocomotiveDetails> LocomotiveDetailsEF { get; set; }
    }
}

