using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoTasks.Models;
using ToDoTasks.ViewModels;

namespace ToDoTasks.Helper.Bindings
{
    public class ToDoTasksBinder : IModelBinder
    {
        /* not used as new task is only a single text description, 
         * possible use if task become more complex model
         * requiring a forms post back from a view model into a dto model */

        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;

            return new ToDoTaskViewModel
            {
                Description = request.Form.Get("Description"),
                DateCreated = DateTime.Now
            };
        }
    }
}