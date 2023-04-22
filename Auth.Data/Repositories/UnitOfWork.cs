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
        public UnitOfWork(
            AuthorizationDbContext dbContext,
            IOrgRepository orgRepository,
            ISiteRepository siteRepository,
            IUserRepository userRepository
        )
        {
            _dbContext = dbContext;
            Orgs = orgRepository;
            Sites = siteRepository;
            Users = userRepository;
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
