using System;
using System.Collections.Generic;
using System.Linq;
using TryItOut.Areas.ToDoTasks.ViewModels;
using TryItOut.DataAccess;
using TryItOut.Service;

namespace TryItOut.Areas.ToDoTasks.Helpers.Views
{
    public class ToDoTasksHelper
    {
        IToDoTasksUnitOfWork service = null;

        public ToDoTasksHelper() { }

        public ToDoTasksHelper(IToDoTasksUnitOfWork service) {

            this.service = service;
        }

        public static ToDoTasksViewModel GenerateVM()
        {
            ToDoTasksViewModel viewModel = new ToDoTasksViewModel();
            ToDoTasksService service = new ToDoTasksService();

            var tasks = service.Read();

            if (tasks.IsValid)
            {
                /* map dto to viewmodel */

                foreach (var task in tasks.ToDoTasksList)
                {
                    viewModel.Tasks.Add(new ToDoTaskViewModel()
                    {
                        Identifier = task.Identifier,
                        Description = task.Description
                    });
                }

                viewModel.NumberOfTasks = tasks.ToDoTasksList.Count;
                viewModel.IsValid = true;
            }
            else
            {
                viewModel.IsValid = false;
            }

            return viewModel;
        }

        public static bool AddNewTask(string description, DateTime requiredBy)
        {
            IList<TryItOut.Domain.Models.ToDoTask> toDoTasks = new List<TryItOut.Domain.Models.ToDoTask>();
            bool status = false;
            XMLReadWrite wrtr = new XMLReadWrite();
           
            try
            {
                /* controller helper should not do any working just calls and mappings */

                /* ********************************************************* */
                /* read existing XML file and add new task to existing tasks
                 * write new task list to XML file                           */
                /* ********************************************************* */
                toDoTasks = wrtr.Read();

                toDoTasks.Add(new TryItOut.Domain.Models.ToDoTask() 
                {
                    Identifier = toDoTasks.Max(i => i.Identifier) + 1,
                    Description = description,
                    RequiredBy = requiredBy
                });

                wrtr.Write(toDoTasks);

                var tasks = wrtr.Read();
            }
            catch
            {

            }

            return status;
        }
    }

    public interface IToDoTasksUnitOfWork
    {
    }
}