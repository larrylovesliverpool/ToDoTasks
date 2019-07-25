using System;
using System.Diagnostics;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TryItOut;
using TryItOut.App_Start;
using TryItOut.Helpers.Logger;
using System.Web.Http;
using System.Web.SessionState;
using TryItOut.Controllers;
using TryItOut.Service;
using TryItOut.CommonInterfaces;

[assembly: PreApplicationStartMethod(typeof(MvcApplication), "Register")]

namespace TryItOut
{
    /* ********************************************************************
    /* possible way of creating an instance of a controller with parameter,
     * using an IoC dependency Injection UNITY 
     * ******************************************************************** */

    //public class CustomControllerFactory : IControllerFactory
    //{
    //    private readonly string _controllerNamespace = "TryItOut.Controllers";

    //    public CustomControllerFactory()
    //    {
    //    }

    //    public IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
    //    {
    //        Type controllerType = Type.GetType(string.Concat(_controllerNamespace, ".", controllerName, "Controller"));
    //        IController controller = Activator.CreateInstance(controllerType) as Controller;

    //        if( controllerName == "Person")
    //        {
    //            ILogin_Service loginService = new Login_Service();
    //            controller = Activator.CreateInstance(controllerType, new[] { loginService } ) as Controller;
    //        }

    //        return controller;
    //    }

    //    public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, string controllerName)
    //    {
    //        return SessionStateBehavior.Default;
    //    }

    //    public void ReleaseController(IController controller)
    //    {
    //        var disposable = controller as IDisposable;
    //        if (disposable != null)
    //        {
    //            disposable.Dispose();
    //        }

    //    }
    //}

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void Register()
        {
            HttpApplication.RegisterModule(typeof(LogModule));
        }

        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AreaRegistration.RegisterAllAreas();
            UnityConfig.RegisterComponents();
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

            // **********
            // Automapper
            // **********
            AutoMapperConfig.RegisterMappers();

            //ControllerBuilder.Current.SetControllerFactory(typeof(CustomControllerFactory));
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            RouteData routeData = RouteTable.Routes.GetRouteData(new HttpContextWrapper(HttpContext.Current));
            //var action = routeData.GetRequiredString("action");
            //var controller = routeData.GetRequiredString("controller");

            /* set/create unit of work according to controller/action */

        }

        protected void Application_MapRequestHandler()
        {
            Debug.WriteLine("Map handler");
        }

        protected void Application_PostMapRequesthandler()
        {
            Debug.WriteLine("Post Map handler");
        }

        protected void Application_AcquireRequestState()
        {
            Debug.WriteLine("Request state");
        }

        protected void Application_PreRequestHandlerexecute()
        {
            Debug.WriteLine("PrerequestHandler Execute");
        }

        protected void Application_PostRequesthandlerExecute()
        {
            Debug.WriteLine("Postrequesthandler Execute");
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            //Common.UnitOfWork.Dispose();
        }

        protected void Application_End()
        {
            Debug.WriteLine("End");
        }
    }
}
