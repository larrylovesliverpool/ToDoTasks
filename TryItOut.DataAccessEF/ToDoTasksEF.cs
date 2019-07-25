using System.Data.Entity;
using System.Diagnostics;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccess
{
    /* ************************* */
    /* ToDoTasks entity framwork */
    /* ************************* */

    public class ToDoTasksEFContext : DbContext
    {
        public ToDoTasksEFContext() : base("Azure-TryItOutEFContext") {

            Debug.Write(Database.Connection.ConnectionString);
        }

        public DbSet<ToDoTask> ToDoTasksEF { get; set; }
    }
}
