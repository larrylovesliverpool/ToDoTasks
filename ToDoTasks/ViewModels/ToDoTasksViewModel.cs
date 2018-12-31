using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoTasks.Models;
using ToDoTasks.ViewModels.BaseModels;

namespace ToDoTasks.ViewModels
{
    public class ToDoTasksViewModel :  BaseViewModel
    {
        public ToDoTasksViewModel()
        {
            IsVaild = false;
            ToDoTasks = new List<ToDoTaskViewModel>();
        }

        public bool IsVaild { get; set; }
        public List<ToDoTaskViewModel> ToDoTasks { get; set; }
    }
}