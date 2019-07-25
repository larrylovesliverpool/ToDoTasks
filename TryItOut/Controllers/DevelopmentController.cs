using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TryItOut.Controllers
{
    public class DevelopmentController : Controller
    {
        // GET: Development
        public ActionResult Index() => View("Index");

        public ActionResult Alt() => View("Alt");
    }
}