using Application.Features.Models.Models;
using Application.Features.Models.Queries.GetListModel;
using Application.Features.Models.Queries.GetListModelByDynamic;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListModelQuery getListModelQuery = new GetListModelQuery { PageRequest = pageRequest };
            ListModelModel result = await Mediator.Send(getListModelQuery);

            return Ok(result);
        }

        /* 4.Gün dynamic query
            {
              "sort": [
                {
                  "field": "string",
                  "dir": "string"
                }
              ],
              "filter": {
                "field": "string",
                "operator": "string",
                "value": "string",
                "logic": "string",
                "filters": [
                  "string"
                ]
              }
            }
        */

        [HttpPost("GetList/ByDynamic")]
        public async Task<ActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] Dynamic dynamic)
        {
            GetListModelByDynamicQuery getListByDynamicModelQuery = new GetListModelByDynamicQuery { PageRequest = pageRequest, Dynamic = dynamic };
            ListModelModel result = await Mediator.Send(getListByDynamicModelQuery);

            return Ok(result);
        }
    }
}