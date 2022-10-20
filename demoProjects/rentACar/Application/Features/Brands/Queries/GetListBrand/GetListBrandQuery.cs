using Application.Features.Brands.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Interfaces.Paging;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetListBrand
{
    public class GetListBrandQuery : IRequest<ListBrandModel>
    {
        public PageRequest? PageRequest { get; set; }

        public class GetListBrandQueryHandler : IRequestHandler<GetListBrandQuery, ListBrandModel>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;

            public GetListBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
            }

            public async Task<ListBrandModel> Handle(GetListBrandQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Brand> brands = await _brandRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

                ListBrandModel mappedBrandListModel = _mapper.Map<ListBrandModel>(brands);

                return mappedBrandListModel;
            }
        }
    }
}