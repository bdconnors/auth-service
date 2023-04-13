using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
