using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TryItOut.ToDoTasks.ViewModels
{
    public class ConfirmationViewModel
    {
        public string MessageText { get; }

        public ConfirmationViewModel()
        {
            MessageText = "Thank you for submitting for details.";
        }

    }
}