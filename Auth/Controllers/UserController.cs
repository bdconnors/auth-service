using Auth.Business.Dto;
using Auth.Business.Interfaces;
using Auth.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUserList()
        {
            IEnumerable<User> users = await _service.GetAll();
            return users;
        }

        [HttpPost]
        public User RegisterUser([FromBody] RegisterUserDto data)
        {
            return _service.Register(data.Email, data.Password, data.MobileNumber);
        }

        [HttpPost]
        [Route("site")]
        public async Task<User> RegisterUserSite([FromBody] RegisterUserSiteDto data)
        {
            return await _service.RegisterUserSite(data.UserId, data.SiteId, data.Role);
        }
    }
}