using Auth.Data.Interfaces;
using System.Data.Entity;

namespace Auth.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _dbContext;
        public IOrgRepository Orgs { get; }
        public ISiteRepository Sites { get; }
        public IRoleRepository Roles { get; }
        public IPermissionRepository Permissions { get; }
        public IUserRepository Users { get; }
        public UnitOfWork(
            Context dbContext,
            IOrgRepository orgRepository,
            ISiteRepository siteRepository,
            IRoleRepository roleRepository,
            IPermissionRepository permissionRepository,
            IUserRepository userRepository
        )
        {
            _dbContext = dbContext;
            Orgs = orgRepository;
            Sites = siteRepository;
            Roles = roleRepository;
            Permissions = permissionRepository;
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
