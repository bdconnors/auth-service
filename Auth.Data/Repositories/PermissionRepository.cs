using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Data.Repositories
{
    public class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        public PermissionRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
