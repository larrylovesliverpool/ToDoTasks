using System.Web;
using System.Web.Mvc;
using TryItOut.Helpers.Filters;

namespace TryItOut
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalAttribute());
        }
    }
}
