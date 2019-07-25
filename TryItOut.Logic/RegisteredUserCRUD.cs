using System;
using System.Linq;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;

namespace TryItOut.Service
{
    public class RegisteredUserCRUD
    {
        private readonly IRegisteredUserCRUD repo;

        public void Read(int identifier)
        {
            using (var context = new ToDoTasksEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var task = context.ToDoTasksEF.Find(identifier);
            }
        }

        public void Read()
        {
            using (var context = new ToDoTasksEFContext())
            {
                context.Database.Log = Console.WriteLine;

                var tasks = context.ToDoTasksEF.ToList();
            }
        }
    }
}
