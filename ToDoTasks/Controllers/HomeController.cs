using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoTasks.Controllers.BaseControllers;

namespace ToDoTasks.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            return RedirectToAction("Index","ToDoTasks");
        }
    }
}