using Auth.Business.Interfaces;
using Auth.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SiteController : ControllerBase
    {
        public readonly ISiteService _service;
        public SiteController(ISiteService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Site>> GetSiteList()
        {
            return await _service.GetAll();
        }
        [HttpPost]
        public Site CreateSite([FromBody] CreateSiteDto data)
        {
            return _service.Create(data.OrgId, data.Name);
        }
    }
}