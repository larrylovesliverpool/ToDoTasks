using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryItOut.Areas.ToDoTasks.Helpers.Views;
using TryItOut.Areas.ToDoTasks.ViewModels;
using TryItOut.ToDoTasks.ViewModels;

namespace TryItOut.Controllers
{
    public class ToDoTasksController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToDo()
        {
            return View(ToDoTasksHelper.GenerateVM());
        }

        public ActionResult ToDoAddTask()
        {
            return View("ToDoAddTask");
        }

        [HttpPost]
        public ActionResult AddTaskSave(FormCollection frmCollection)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var Description = frmCollection["Description"].ToString();
                    var reqdDate = Convert.ToDateTime(frmCollection["RequiredBy"].ToString());
                    var taskType = frmCollection["StudentGender"].ToString();

                    ToDoTasksHelper.AddNewTask(Description, reqdDate);
                }
                catch( Exception ex)
                {

                }
            }

            return View("ToDo", ToDoTasksHelper.GenerateVM());
        }

        [HttpPost]
        public ActionResult AddTaskCancel(FormCollection frmCollection)
        {

            return View("ToDo", ToDoTasksHelper.GenerateVM());
        }
    }


}