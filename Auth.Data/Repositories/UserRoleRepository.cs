using Auth.Data.Interfaces;
using Auth.Data.Models;
using System.Data.Entity;

namespace Auth.Data.Repositories
{
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(AuthorizationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
