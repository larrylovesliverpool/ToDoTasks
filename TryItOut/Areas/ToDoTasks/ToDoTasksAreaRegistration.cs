using System.Web.Mvc;

namespace TryItOut.Areas.ToDoTasks
{
    public class ToDoTasksAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ToDoTasks";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ToDoTasks_default",
                "ToDoTasks/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}