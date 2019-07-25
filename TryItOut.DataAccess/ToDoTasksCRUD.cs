using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;
using TryItOut.Domain.Models;

namespace TryItOut.DataAccess
{
    public class ToDoTasksCRUD : IToDoTasksCRUD
    {
        public Domain.Models.ToDoTask Read(int identifier)
        {
            using (var context = new ToDoTasksEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var task = context.ToDoTasksEF.Find(identifier);

                return task;
            }
        }

        public List<Domain.Models.ToDoTask> Read()
        {
            using (var context = new ToDoTasksEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var tasks = context.ToDoTasksEF.ToList();

                return tasks;
            }
        }

    }
}
