using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;
using TryItOut.Domain;
using TryItOut.Domain.Models;

namespace TryItOut.Logic.Common
{
    public class UnitOfWork_ToDoTasks : IDisposable
    {
        private IToDoTasksRepository toDoTasks;

        private GenericRepository<ToDoTask> genericToDoTasksRepo;

        private GenericRepository<Domain.Person> genericPersonRepo;

        public IToDoTasksRepository ToDoTasks {

            get
            {
                if (this.toDoTasks == null)
                    this.toDoTasks = new ToDoTasksRepository();

                return toDoTasks;
            }
        }

        public GenericRepository<ToDoTask> GenericToDoTasks
        {
            get
            {
                if (this.genericToDoTasksRepo == null)
                    this.genericToDoTasksRepo = new GenericRepository<ToDoTask>();

                return genericToDoTasksRepo;
            }
        }

        public UnitOfWork_ToDoTasks() { }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
