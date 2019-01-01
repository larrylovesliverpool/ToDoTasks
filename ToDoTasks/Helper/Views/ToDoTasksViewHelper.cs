using Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ToDoTasks.Domain.DataTransferObjects;
using ToDoTasks.Service;
using ToDoTasks.ViewModels;
using AutoMapper;
using ToDoTasks.Helper.Views;

namespace ToDoTasks.Helper.View
{
    public class ToDoTasksViewHelper : IToDoTasksViewhelper
    {
        public IToDoTasksService service = null;
        private ToDoTasksViewModel _vm;

        public ToDoTasksViewModel Vm
        {
            get
            {
                return _vm;
            }

            private set
            {
                _vm = value;
            }
        }

        public ToDoTasksViewHelper() {

            /* default service, replace with Ioc, Di */
            service = new ToDoTasksService();
        }

        public ToDoTasksViewHelper(IToDoTasksService service) {

                this.service = service;
        }

        // ***********************
        // generate the view model
        // ***********************

        public ToDoTasksViewModel GenerateViewModel()
        {
            // view model
            Vm = new ToDoTasksViewModel();
            // Dto
            ToDoTasksDto dto = service.Generate();

            // map to Vm

            foreach (var task in dto.ToDoTasks)
            {
                Vm.ToDoTasks.Add(new ViewModels.ToDoTaskViewModel() { Identifier = task.Identifier, Description = task.Description });
            }

            return Vm;
        }

    }
}