using Auth.Data.Interfaces;
using Auth.Data.Models;
using System.Data.Entity;

namespace Auth.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AuthorizationDbContext dbContext) : base(dbContext)
        { 
        }
    }
}
