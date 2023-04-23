using Auth.Data.Interfaces;
using Auth.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Data.Repositories
{
    public class UserSiteRepository: Repository<UserSite>, IUserSiteRepository
    {
        public UserSiteRepository(AuthorizationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
