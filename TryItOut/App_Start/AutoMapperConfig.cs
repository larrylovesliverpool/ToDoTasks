using AutoMapper;
using TryItOut.ViewModels;
using TryItOut.Domain;
using System.Web.Mvc;
using TryItOut.Areas.ToDoTasks.ViewModels;

namespace TryItOut.App_Start
{
    public class AutoMapperConfig
    {

        public static void RegisterMappers()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Person, PersonViewModel>();
                cfg.CreateMap<string, string>();
                cfg.CreateMap<FormCollection, NewTaskViewModel>();
                cfg.CreateMap<string, NewTaskViewModel>();
            });
        }

    }
}