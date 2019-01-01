using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoTasks.ViewModels;

namespace ToDoTasks.Helper.Views
{
    public interface IToDoTasksViewhelper
    {
        ToDoTasksViewModel GenerateViewModel();
    }
}
