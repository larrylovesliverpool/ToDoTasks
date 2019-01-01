
using AutoMapper;
using ToDoTasks.Domain.DataTransferObjects;
using ToDoTasks.ViewModels;

namespace ToDoTasks
{
    public class AutoMapperConfig
    {
        public static void RegisterMappers()
        {
            // ***********************
            // mappings between models
            // ***********************

            //Mapper.Initialize(cfg => {
            //    cfg.CreateMap<Domain, VM>();
            //    cfg.CreateMap<Domain, dto>();
            //});

            Mapper.Initialize(cfg => {
                cfg.CreateMap<ToDoTasksDto, ToDoTasksViewModel>();
            });
        }
    }
}