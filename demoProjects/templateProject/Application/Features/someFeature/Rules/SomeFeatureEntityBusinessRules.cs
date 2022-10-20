using Application.Services.Repositories;
using Core.CrossCuttingConcern.Exceptions.ExceptionModels;
using Core.Persistence.Interfaces.Paging;
using Domain.Entities;

namespace Application.Features.someFeature.Rules
{
    public class SomeFeatureEntityBusinessRules
    {
        private readonly ISomeFeatureEntityRepository _someFeatureEntityRepository;

        public SomeFeatureEntityBusinessRules(ISomeFeatureEntityRepository someFeatureEntityRepository)
        {
            _someFeatureEntityRepository = someFeatureEntityRepository;
        }
        public async Task SomeFeatureEntityNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<SomeFeatureEntity> result = await _someFeatureEntityRepository.GetListAsync(b => b.Name == name);
            
            if (result.Items.Any()) 
                throw new BusinessException("SomeFeatureEntity name exists.");
        }
    }
}