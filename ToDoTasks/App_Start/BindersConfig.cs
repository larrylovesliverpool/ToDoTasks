using System.Web.Mvc;
using ToDoTasks.Helper.Bindings;

namespace ToDoTasks
{
    public class BindersConfig
    {

        public static void RegisterBinders()
        {
            ModelBinders.Binders.Add(typeof(ToDoTasksBinder), new ToDoTasksBinder());
        }
    }
}