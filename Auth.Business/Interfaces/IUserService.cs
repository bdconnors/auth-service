using Auth.Business.Dto;
using Auth.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Business.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> Get(int id);
        User Add(CreateUserDto data);
        ICollection<UserRole> MakeUserRoles(int userId, IEnumerable<int> roleIds);
    }
}
