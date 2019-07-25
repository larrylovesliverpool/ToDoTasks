using System;
using System.Web;
using System.Web.Mvc;
using TryItOut.ViewModels;

namespace TryItOut.Helpers
{
    public class PersonBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpRequestBase request = controllerContext.HttpContext.Request;

            // Can use this technique to map form model to ViewModel.

            return new PersonViewModel {

                Name = request.Form.Get("Name"),
                Address = request.Form.Get("Address"),
                Postcode = request.Form.Get("Postcode"),
                Nationality = request.Form.Get("Nationality"),
                Identifier = request.Form.Get("Identifier")
            };
        }
    }
}