using System.Web.Mvc;

namespace ToDoTasks.Controllers.BaseControllers
{
    public class BaseController : Controller
    {
        public BaseController() : base() { }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

    }
}