using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTasks.Domain.DataTransferObjects.Interfaces
{
    public interface IToDoTasksDto
    {
        IList<ToDoTaskDto> ToDoTasks { get; set; }
    }
}
