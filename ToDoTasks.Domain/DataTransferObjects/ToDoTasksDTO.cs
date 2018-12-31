using System;
using System.Collections.Generic;
using ToDoTasks.Domain.DataTransferObjects.Interfaces;

namespace ToDoTasks.Domain.DataTransferObjects
{
    public class ToDoTaskDto : IToDoTaskDto
    {
        public int Identifier { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Completed { get; set; }
        public bool Deleted { get; set; }
    }

    public class ToDoTasksDto : IToDoTasksDto
    {
        public IList<ToDoTaskDto> ToDoTasks { get; set; }

        public ToDoTasksDto() {

            ToDoTasks = new List<ToDoTaskDto>();
        }
    }
}