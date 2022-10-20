using Application.Features.Models.Models;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Interfaces.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Models.Queries.GetListModel
{
    public class GetListModelQuery : IRequest<ListModelModel>
    {
        public PageRequest? PageRequest { get; set; }

        public class GetListModelQueryHandler : IRequestHandler<GetListModelQuery, ListModelModel>
        {
            private readonly IModelRepository _modelRepository;
            private readonly IMapper _mapper;

            public GetListModelQueryHandler(IModelRepository modelRepository, IMapper mapper)
            {
                _modelRepository = modelRepository;
                _mapper = mapper;
            }

            public async Task<ListModelModel> Handle(GetListModelQuery request, CancellationToken cancellationToken)
            {
                //Car models
                IPaginate<Model> models = await _modelRepository.GetListAsync(include: m => m.Include(c => c.Brand),
                                                                              index: request.PageRequest.Page,
                                                                              size: request.PageRequest.PageSize);

                //Data model
                ListModelModel mappedModels = _mapper.Map<ListModelModel>(models);

                return mappedModels;
            }
        }
    }
}