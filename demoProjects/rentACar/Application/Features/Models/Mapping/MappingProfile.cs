using Application.Features.Models.DTOs;
using Application.Features.Models.Models;
using AutoMapper;
using Core.Persistence.Interfaces.Paging;
using Domain.Entities;

namespace Application.Features.Models.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Model, ListModelDto>().ForMember(x => x.BrandName, opt => opt.MapFrom(y => y.Brand.Name)).ReverseMap();

            CreateMap<IPaginate<Model>, ListModelModel>().ReverseMap();
        }
    }
}