using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryItOut.Service
{
    /* Single ToDoTask for DTO */
    public class ToDoTaskDTO
    {
        public int Identifier { get; set; }
        public string Description { get; set; }
    }

    /* Full DTO for ToDo Tasks */
    public class ToDoTasksListDTO
    {
        public bool IsValid { get; set; }
        public List<ToDoTaskDTO> ToDoTasksList { get; set; }
        public int NumberOf { get; set; }

        /* initialise DTO */
        public ToDoTasksListDTO()
        {
            this.IsValid = false;
            this.ToDoTasksList = new List<ToDoTaskDTO>();
            this.NumberOf = 0;
        }
    }
}
