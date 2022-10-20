using Application.Features.someFeature.DTOs;
using AutoMapper;
using Entities.Entities;

namespace Application.Features.someFeature.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<SomeFeatureEntity, CreatedSomeFeatureEntityDto>().ReverseMap();
        }
    }
}