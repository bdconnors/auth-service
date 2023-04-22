using Auth.Data.Interfaces;
using Auth.Data.Models;
using System.Data.Entity;

namespace Auth.Data.Repositories
{
    public class OrgRepository : Repository<Org>, IOrgRepository
    {
        public OrgRepository(AuthorizationDbContext dbContext) : base(dbContext)
        {
      
        }
        public new async Task<IEnumerable<Org>> GetAll()
        {
            return await _dbContext.Set<Org>().Include(org => org.Sites).ToListAsync();
        }
    }
}
