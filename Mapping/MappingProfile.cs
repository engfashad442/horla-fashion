using ahmad.Controllers.Resources;
using ahmad.Models;
using AutoMapper;

namespace ahmad.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()

        {
            CreateMap<Make,MakeResource>();
            CreateMap<Model,ModelResource>();
        }
    }
}