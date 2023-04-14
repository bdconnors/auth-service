using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Data.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(Context dbContext) : base(dbContext)
        {
            
        }

        public IEnumerable<Role> GetDefaultRoles()
        {
            return _dbContext.Roles
                .Where(perm => perm.Title.Equals("ADMIN") || perm.Title.Equals("CONTRIBUTOR") || perm.Title.Equals("READER"))
                .ToList();
        }
    }
}
