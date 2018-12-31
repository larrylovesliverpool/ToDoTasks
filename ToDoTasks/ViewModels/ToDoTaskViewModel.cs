using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoTasks.ViewModels
{
    public class ToDoTaskViewModel
    {
        public int Identifier { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
