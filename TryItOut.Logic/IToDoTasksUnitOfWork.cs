using System;
using TryItOut.Logic.DTOs;

namespace TryItOut.Service
{
    public interface IToDoTasksUnitOfWork
    {
        ToDoTasksListDTO GetTasksForView();
    }
}
