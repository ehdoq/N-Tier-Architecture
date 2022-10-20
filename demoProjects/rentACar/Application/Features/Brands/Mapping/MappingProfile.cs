using Application.Features.Brands.Commands.CreateBrand;
using Application.Features.Brands.DTOs;
using Application.Features.Brands.Models;
using AutoMapper;
using Core.Persistence.Interfaces.Paging;
using Domain.Entities;

namespace Application.Features.Brands.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Brand, CreatedBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<IPaginate<Brand>, ListBrandModel>().ReverseMap();
            CreateMap<Brand, ListBrandDto>().ReverseMap();
        }
    }
}