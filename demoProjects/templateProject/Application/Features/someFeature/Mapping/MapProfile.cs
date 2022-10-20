using Application.Features.someFeature.Commands.CreateSomeFeature;
using Application.Features.someFeature.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.someFeature.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<CreatedSomeFeatureEntityDto, SomeFeatureEntity>().ReverseMap();
            CreateMap<CreateSomeFeatureEntityCommand, SomeFeatureEntity>().ReverseMap();
        }
    }
}