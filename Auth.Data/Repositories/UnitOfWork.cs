using Auth.Data.Interfaces;
using System.Data.Entity;

namespace Auth.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AuthorizationDbContext _dbContext;
        public IOrgRepository Orgs { get; }
        public ISiteRepository Sites { get; }
        public IUserRepository Users { get; }
        public IUserSiteRepository UserSites { get; }
        public UnitOfWork(
            AuthorizationDbContext dbContext,
            IOrgRepository orgRepository,
            ISiteRepository siteRepository,
            IUserRepository userRepository,
            IUserSiteRepository userSiteRepository
        )
        {
            _dbContext = dbContext;
            Orgs = orgRepository;
            Sites = siteRepository;
            Users = userRepository;
            UserSites = userSiteRepository;
        }
        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
