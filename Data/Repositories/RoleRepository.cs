using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Data.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
