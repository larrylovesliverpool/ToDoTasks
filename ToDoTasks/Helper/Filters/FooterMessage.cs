
using System;
using System.Configuration;
using System.Web.Mvc;

namespace ToDoTasks.Helper.Filter
{

    public class FooterMessageAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            filterContext.Controller.ViewBag.FooterMessage = "Version : " + (ConfigurationManager.AppSettings["Environment"].ToString() + " " + assembly) ?? string.Empty;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext) { }
    }

}