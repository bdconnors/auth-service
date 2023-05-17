using Auth.Business.Dto;
using Auth.Business.Interfaces;
using Auth.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TenantController : ControllerBase
    {
        public readonly ITenantService _service;
        public TenantController(ITenantService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Tenant>> GetTenantList()
        {
            return await _service.GetAll();
        }


        [HttpPost]
        public Tenant CreateTenant([FromBody] CreateTenantDto body)
        {
            return _service.Create(body.Name);
        }
    }
}