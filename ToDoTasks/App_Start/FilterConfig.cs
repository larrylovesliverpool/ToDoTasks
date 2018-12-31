using System.Web;
using System.Web.Mvc;
using ToDoTasks.Helper.Filter;

namespace ToDoTasks
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            // **
            // page footer global filter
            // **

            filters.Add(new FooterMessageAttribute());
        }
    }
}
