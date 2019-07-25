using System.Collections.Generic;
using TryItOut.ToDoTasks.ViewModels;

namespace TryItOut.Areas.ToDoTasks.ViewModels
{
    public class ToDoTaskViewModel
    {
        public int Identifier { get; set; }

        public string Description { get; set; }
    }

    public class ToDoTasksViewModel : ConfirmationViewModel
    {
        public ToDoTasksViewModel()
        {
            IsValid = false;
            Tasks = new List<ToDoTaskViewModel>();
            NumberOfTasks = 0;
        }

        public bool IsValid { get; set; }

        public IList<ToDoTaskViewModel> Tasks { get; set; }

        public int NumberOfTasks { get; set; }

        public int NumberOfOutStandingTasks { get; set; }

        public int NumberOfCompletedTasks { get; set; }
    }
}