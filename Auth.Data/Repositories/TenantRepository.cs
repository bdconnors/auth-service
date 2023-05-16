using Auth.Data.Interfaces;
using Auth.Data.Models;
using System.Data.Entity;

namespace Auth.Data.Repositories
{
    public class TenantRepository : Repository<Tenant>, ITenantRepository
    {
        public TenantRepository(AuthorizationDbContext dbContext) : base(dbContext)
        {
      
        }
    }
}
