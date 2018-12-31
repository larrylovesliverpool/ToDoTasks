using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ToDoTasks;
using ToDoTasks.Helper;
using ToDoTasks.Helper.Logger;

/* application start methods */
[assembly: PreApplicationStartMethod(typeof(MvcApplication), "Register")]

namespace ToDoTasks
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void Register()
        {
            HttpApplication.RegisterModule(typeof(LogModule));
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // *************
            // Model binders
            // *************
            BindersConfig.RegisterBinders();

            // **************
            // IoC initialise
            // **************
            //StructureMapResolver = new StructureMapDependencyResolver(BootStrapper.ConfigureStructureMap());
            //DependencyResolver.SetResolver(StructureMapResolver);

            // **********
            // Automapper
            // **********
            AutoMapperConfig.RegisterMappers();
        }
    }
}
