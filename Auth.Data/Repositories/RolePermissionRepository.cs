using Auth.Data.Interfaces;
using Auth.Data.Models;
using System.Data.Entity;

namespace Auth.Data.Repositories
{
    public class RolePermissionRepository : Repository<RolePermission>, IRolePermissionRepository
    {
        public RolePermissionRepository(AuthorizationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
