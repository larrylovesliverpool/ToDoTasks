using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoTasks.Domain.DataTransferObjects.Interfaces
{
    public interface IToDoTaskDto
    {
        int Identifier { get; set; }
        string Description { get; set; }
        DateTime DateCreated { get; set; }
        bool Completed { get; set; }
        bool Deleted { get; set; }
    }
}
