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

        [HttpGet]
        [Route("{id}")]
        public async Task<User> GetUser(int id)
        {
            return await _service.Get(id);
        }

        [HttpPost]
        public async Task<User> CreateUser([FromBody] CreateUserDto body)
        {
            User user = _service.Add(body);
            return user;
        }

    }
}