using Application.Features.Brands.DTOs;
using Core.Persistence.Paging;

namespace Application.Features.Brands.Models
{
    public class ListBrandModel : BasePageableModel
    {
        public IList<ListBrandDto>? Items { get; set; }
    }
}