using Auth.Business.Interfaces;
using Auth.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrgController : ControllerBase
    {
        public readonly IOrgService _service;
        public OrgController(IOrgService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Org>> GetOrgList()
        {
            return await _service.GetAll();
        }
    }
}