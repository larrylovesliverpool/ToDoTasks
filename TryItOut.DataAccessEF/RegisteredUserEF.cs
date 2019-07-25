using System.Data.Entity;
using System.Diagnostics;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccess
{
    public class RegisteredUserEFContext : DbContext
    {
        public RegisteredUserEFContext() : base("name=LarryDataBase") {

            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<RegisteredUser> RegisteredUserEF { get; set; }
    }
}
