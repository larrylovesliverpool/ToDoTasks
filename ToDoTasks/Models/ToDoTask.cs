using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoTasks.Models
{
    public class ToDoTask
    {
        public int Identifier { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Completed { get; set; }
        public bool Deleted { get; set; }
    }
}
