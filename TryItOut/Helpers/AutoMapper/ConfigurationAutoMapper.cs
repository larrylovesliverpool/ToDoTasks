using AutoMapper;
using TryItOut.ViewModels;
using TryItOut.Domain;

namespace TryItOut.Helpers.AutoMapper
{
    public class ConfigurationAutoMapper
    {
        public static void RegisterMappers()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Person, PersonViewModel>());
        }
    }
}

