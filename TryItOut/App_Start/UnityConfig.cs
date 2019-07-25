using System.Web.Mvc;
using TryItOut.CommonInterfaces;
using TryItOut.DataAccess;
using TryItOut.DataAccessEF;
using TryItOut.Helpers.Views;
using TryItOut.Logic;
using TryItOut.Service;
using TryItOut.Service.DTOs;
using TryItOut.Service.Interfaces;
using Unity;
using Unity.Mvc5;

namespace TryItOut
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ILogin_Service, Login_Service>();

            container.RegisterType<IRegisteredUserRepository, RegisteredUserRepository>();

            container.RegisterType<ILocomotiveService, LocomotiveService>();

            container.RegisterType<ITrainsPlanesCars, TrainsPlanesCars>();

            container.RegisterType<ILocomotiveRepository, LocomotiveRepository>();

            container.RegisterType<ILogin_UnitOfWork, Login_UnitOfWork>();

            container.RegisterType<IViewModelFactory, ViewModelFactory>();

            container.RegisterType<ILocomotiveTypesCRUD, LocomotiveTypeCRUD>();

            container.RegisterType<ILocomotiveTypeService, LocomotiveTypeService>();

            container.RegisterType<IRailwaysManufacturService, RailwaysmanufacturerService>();

            container.RegisterType<IRailwaysManufacturerCRUD, RailwaysManufacturerCRUD>();

            container.RegisterType<IRailwayDecoderCRUD, RailwayDecoderCRUD>();

            container.RegisterType<IRailwayDecoderService<RailwayDecoderDTO>, RailwayDecoderService>();

            container.RegisterType<IDecoderhelper, DecoderHelper>();

            container.RegisterType<IRailwaysManufacturersListOf, RailwaysManufacturersListOf>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}