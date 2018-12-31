using Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoTasks.Domain.DataTransferObjects;

namespace Interfaces.Service
{
    public interface IToDoTasksService
    {
        ToDoTasksDto Generate();
    }
}
