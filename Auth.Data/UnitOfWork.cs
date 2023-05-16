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
        public IRoleRepository Roles { get; }
        public IPermissionRepository Permissions { get; }
        public IUserRoleRepository UserRoles { get; }
        public IRolePermissionRepository RolePermissions { get; }

    public UnitOfWork(
            AuthorizationDbContext dbContext,
            ITenantRepository tenants,
            IUserRepository users,
            IRoleRepository roles,
            IPermissionRepository permissions,
            IUserRoleRepository userRoles,
            IRolePermissionRepository rolePermissions
        )
        {
            _dbContext = dbContext;
            Tenants = tenants;
            Users = users;
            Roles = roles;
            Permissions = permissions;
            UserRoles = userRoles;
            RolePermissions = rolePermissions;

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
