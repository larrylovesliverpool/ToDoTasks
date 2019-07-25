using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryItOut.Controllers.BaseControllers;
using TryItOut.Helpers.Views;
using TryItOut.ViewModels;

namespace TryItOut.Controllers
{
    public class HomeController : BaseController
    {
        readonly IViewModelFactory viewfactory;

        public HomeController(IViewModelFactory viewfactory)
        {
            this.viewfactory = viewfactory;
        }

        public ActionResult Index()
        {
            /* create a factory class/method to create viewmodel */
            var vm = viewfactory.CreateHomeViewModel("Home", "Welcome");

            return View("Index",vm);
        }

        public ActionResult About()
        {
            /* create a factory class/method to create viewmodel */
            var vm = viewfactory.CreateAboutViewModel();

            return View("About", vm);
        }

        public ActionResult Welcome() => View("Welcome");

    }
}