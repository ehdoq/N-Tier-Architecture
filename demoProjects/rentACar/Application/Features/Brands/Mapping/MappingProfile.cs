using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.DTOs;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.Brands.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Brand, CreatedBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        }
    }
}