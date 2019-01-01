using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using Interfaces.Service;
using ToDoTasks.Service;
using ToDoTasks.Helper.Views;
using ToDoTasks.Helper.View;

namespace WebSite.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //kernel.Bind<ILocomotiveRepository>().To<LocomotiveRepository>();
            kernel.Bind<IToDoTasksViewhelper>().To<ToDoTasksViewHelper>();
        }
    }
}