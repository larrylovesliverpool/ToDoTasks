using System.Data.Entity;
using System.Diagnostics;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccessEF
{
    public class RailwayDecoderEFContext : DbContext
    {
        public RailwayDecoderEFContext() : base("name=LarryDataBase") {

            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<RailwayDecoder> RailwayDecoderEF { get; set; }
    }
}
