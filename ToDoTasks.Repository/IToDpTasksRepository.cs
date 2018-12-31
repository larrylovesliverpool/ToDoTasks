using System.Collections.Generic;
using ToDoTasks.Domain;

namespace ToDoTasks.Repository
{
    public interface IToDpTasksRepository
    {
        IList<ToDoTask> ReadTasks();
    }
}