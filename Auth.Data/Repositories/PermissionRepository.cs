using Auth.Data.Interfaces;
using Auth.Data.Models;
using System.Data.Entity;

namespace Auth.Data.Repositories
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        public PermissionRepository(AuthorizationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
