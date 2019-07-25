using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryItOut.Logic;
using TryItOut.Logic.Interfaces;
using TryItOut.ViewModels;

namespace TryItOut.Helpers.Views
{
    public class LocomotiveTypes
    {
        ILocomotiveTypeService service = null;

        public LocomotiveTypes(ILocomotiveTypeService service) {

            this.service = service;
        }

        public LocomotiveTypeViewModel CreateViewModel()
        {
            LocomotiveTypeViewModel vm = new LocomotiveTypeViewModel();

            service.Read();

            return vm;
        }
    }
}