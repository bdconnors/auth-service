using Auth.Data.Interfaces;
using Auth.Data.Models;

namespace Auth.Data.Repositories
{
    public class OrgRepository : Repository<Org>, IOrgRepository
    {
        public OrgRepository(Context dbContext) : base(dbContext)
        {

        }
    }
}
