using Application.Features.Models.DTOs;
using Core.Persistence.Paging;

namespace Application.Features.Models.Models
{
    public class ListModelModel : BasePageableModel
    {
        public IList<ListModelDto>? Items { get; set; }
    }
}