using System.Data.Entity;
using System.Diagnostics;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccess
{
    public class DecoderCVValueEFContext : DbContext
    {
        public DecoderCVValueEFContext() : base("name=LarryDataBase") {

            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<DecoderCVValue> DecoderCVValueEF { get; set; }
    }
}
