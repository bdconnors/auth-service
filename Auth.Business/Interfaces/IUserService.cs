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
        User Register(string email, string password);
        Task<User> RegisterUserSite(int userId, int siteId, string role);
        Task<IEnumerable<User>> GetAll();
    }
}
