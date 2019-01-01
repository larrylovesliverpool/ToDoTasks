using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoTasks.Controllers.BaseControllers;
using ToDoTasks.Helper.View;
using ToDoTasks.Helper.Views;
using ToDoTasks.ViewModels;

namespace ToDoTasks.Controllers
{
    public class ToDoTasksController : BaseController
    {
        IToDoTasksViewhelper viewHelper;

        public ToDoTasksController(IToDoTasksViewhelper helper)
        {
            viewHelper = helper;
        }

        //public ActionResult Index()
        //{
        //    //var vm = new ToDoTasksViewHelper().GenerateViewModel();
        //    var vm = viewHelper.GenerateViewModel();

        //    return View(vm);
        //}

        public ActionResult Index() => View(viewHelper.GenerateViewModel() );

        [HttpPost]
        public ActionResult DeleteTask(int taskId)
        {
            //ToDo - persist data change to database/xml file //

            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult CompletedTask(int taskId)
        {
            //ToDo - persist data change to database/xml file //

            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult AddTask()
        {
            //ToDo - persist data change to database/xml file //

            return new EmptyResult();
        }
    }
}