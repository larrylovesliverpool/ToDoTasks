
using System.Web.Mvc;
using TryItOut.Helpers;

namespace TryItOut.App_Start
{
    public class BindersConfig
    {
        public static void RegisterBinders()
        {
            ModelBinders.Binders.Add( typeof(PersonBinder), new PersonBinder() );
        }
    }
}