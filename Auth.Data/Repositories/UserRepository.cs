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
        public new async Task<IEnumerable<User>> GetAll()
        {
            return await _dbContext.Users.Include(user => user.UserSites).ToListAsync();
        }
    }
}
