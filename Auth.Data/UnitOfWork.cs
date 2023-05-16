using Auth.Data.Interfaces;
using Auth.Data.Models;
using System.Data.Entity;

namespace Auth.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AuthorizationDbContext _dbContext;
        public ITenantRepository Tenants { get; }
        public IUserRepository Users { get; }
        public UnitOfWork(
            AuthorizationDbContext dbContext,
            ITenantRepository tenantRepository,
            IUserRepository userRepository
        )
        {
            _dbContext = dbContext;
            Tenants = tenantRepository;
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
